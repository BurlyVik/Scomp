using System.Windows.Forms;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Drawing;
using System.Runtime;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Diagnostics.Eventing.Reader;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using FileSystem = Microsoft.VisualBasic.FileIO.FileSystem;
using SearchOption = System.IO.SearchOption;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace scomp
{
    public partial class Form1 : Form
    {
        private ListViewColumnSorter columnSorter;

        Dictionary<string, List<FileInfo>> hashList = new Dictionary<string, List<FileInfo>>();
        private int colorIndex = 45;
        splash splashScreen;
        System.Windows.Forms.Timer timer;
        public Form1()
        {
            InitializeComponent();

            // Set up the ListView
            listView1.SetDoubleBuffered(true);
            listView1.View = View.Details;
            listView1.Columns.Add("File", 200);
            listView1.Columns.Add("Created", 100);
            listView1.Columns.Add("Bytes", 100);
            listView1.Columns.Add("SHA-256", 100);
            listView1.Columns.Add("Location", 100);

            columnSorter = new ListViewColumnSorter();
            this.listView1.ListViewItemSorter = columnSorter;

            splashScreen = new splash(this);
            timer = new System.Windows.Forms.Timer { Interval = 5000 }; // 4000 milliseconds = 4 seconds
            timer.Tick += (sender, e) =>
            {
                timer.Stop(); // Stop the timer after the first tick to prevent it from ticking again
                splashScreen.Close(); // Close the splash screen
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the ListView large image list to the one containing file icons
            listView1.LargeImageList = imageList1;

            timer.Start();
            splashScreen.ShowDialog();
        }

        static string CalculateSHA256(string filePath)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                using (FileStream fileStream = File.OpenRead(filePath))
                {
                    byte[] hashBytes = sha256.ComputeHash(fileStream);
                    return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                }
            }
        }

        private async void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear existing items in the ListView
            imageList1.Images.Clear();
            listView1.Items.Clear();

            CommonOpenFileDialog openFileDialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                RestoreDirectory = true,
                DefaultDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            if (openFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                listView1.Items.Clear();
                await ProcessDirectoryAsync(openFileDialog.FileName);
                lblPath.Text = openFileDialog.FileName;
            }
        }

        private async Task ProcessDirectoryAsync(string directoryPath)
        {
            DirectoryInfo di = new DirectoryInfo(directoryPath);
            FileInfo[] files = di.GetFiles("*", SearchOption.AllDirectories);
            int totalFiles = files.Length;

            // Assuming 'ProgressForm' is the correct class name
            progress progressForm = new progress(this);
            progressForm.StartPosition = FormStartPosition.Manual;
            progressForm.Location = new Point(
                this.Location.X + (this.Width - progressForm.Width) / 2,
                this.Location.Y + (this.Height - progressForm.Height) / 2
            );

            progressForm.SetProgressMax(100);
            progressForm.Show(); // Show the progress form immediately before processing

            await Task.Run(() =>
            {
                int processedFiles = 0;
                foreach (FileInfo file in files)
                {
                    string hash = CalculateSHA256(file.FullName);
                    if (!hashList.ContainsKey(hash))
                    {
                        hashList[hash] = new List<FileInfo>();
                    }
                    hashList[hash].Add(file);

                    processedFiles++;
                    int progressPercentage = (int)((double)processedFiles / totalFiles * 100);
                    progressForm.Invoke(new Action(() => progressForm.UpdateProgress(progressPercentage)));
                }
            });

            // Directly update to maximum to ensure completeness
            progressForm.UpdateProgress(100); // Assuming UpdateProgress can handle being called from any thread

            await Task.Delay(1500); // Give users time to see progress completion

            AssignColorsAndPopulateListView(); // This should be thread-safe; if not, wrap in Invoke

            progressForm.Close(); // Assuming ProgressForm.Close is safe to call from any thread; otherwise, wrap in Invoke
        }

        private void AssignColorsAndPopulateListView()
        {
            
            foreach (var hashGroup in hashList)
            {
                Color groupColor = GetNextColor();
                foreach (var file in hashGroup.Value)
                {
                    ListViewItem item = new ListViewItem(new string[] {
                    Path.GetFileName(file.FullName),
                    file.LastAccessTime.ToString(),
                    file.Length.ToString(),
                    hashGroup.Key,
                    file.FullName
                });

                    // Assign the color to the ListViewItem (e.g., background color)
                    item.ForeColor = groupColor;

                    listView1.Items.Add(item);
                }
            }

            foreach (ColumnHeader column in listView1.Columns)
            {
                column.Width = -2;
            }

            hashList = new Dictionary<string, List<FileInfo>>();
        }

        private Color GetNextColor()
        {
            // Define the initial high value for contrast against dark backgrounds.
            int highValue = 128; // Adjust as needed to ensure contrast.

            // Cycle through colors by altering which component (R, G, B) is incremented.
            // This example uses a simple pattern but can be adjusted for a wider variety of colors.
            int r = (colorIndex % 3 == 0) ? highValue : (colorIndex++ * 5) % 256;
            int g = (colorIndex % 3 == 1) ? highValue : (colorIndex * 7) % 256; // Use different prime numbers for variation.
            int b = (colorIndex % 3 == 2) ? highValue : (colorIndex * 11) % 256;

            // Ensure we cycle through different adjustments to avoid immediate repeats.
            colorIndex++;

            // Return the next color with at least one component set to ensure contrast against dark backgrounds.
            return Color.FromArgb(255, r, g, b);
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                ListViewItem lvi = listView1.SelectedItems[0];
                if (File.Exists(lvi.SubItems[4].Text))
                {
                    Process p = new Process();
                    ProcessStartInfo processStartInfo = new ProcessStartInfo();
                    processStartInfo.UseShellExecute = true;
                    processStartInfo.FileName = lvi.SubItems[4].Text;
                    p.StartInfo = processStartInfo;
                    try
                    {
                        p.Start();
                    }
                    catch (Exception ex) { }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                this.TopMost = true;
            else
                this.TopMost = false;
        }       

        public void RenameFileUpdateSelectedListItem(ListViewItem lvItem)
        {
            string entityExtension = Path.GetExtension(lvItem.Text);
            var entityDirectory = new FileInfo(lvItem.SubItems[4].Text).Directory?.FullName;
            string usrInpt = string.Empty; //Microsoft.VisualBasic.Interaction.InputBox("Name", "Rename File", Path.GetFileNameWithoutExtension(lvItem.Text),(int)(this.Width/3), (int)(this.Height/ 3));

            Prompt prompt = new Prompt(Path.GetFileNameWithoutExtension(lvItem.Text));

            if (prompt.ShowDialog() != DialogResult.OK)
                usrInpt = prompt.NewFileName;

            var newName = $"{usrInpt}{entityExtension}";
            if (Directory.Exists(entityDirectory))
            {
                File.Move(lvItem.SubItems[4].Text, Path.Combine(entityDirectory, $"{newName}"));
                lvItem.Text = newName;
                lvItem.SubItems[4].Text = Path.Combine(entityDirectory, $"{usrInpt}{entityExtension}");
            }
        }        

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == columnSorter.SortColumn)
            {
                if (columnSorter.Order == SortOrder.Ascending)
                    columnSorter.Order = SortOrder.Descending;
                else
                    columnSorter.Order = SortOrder.Ascending;
            }
            else
            {
                columnSorter.SortColumn = e.Column;
                columnSorter.Order = SortOrder.Ascending;
            }

            this.listView1.Sort();
        }

        private void recycleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = listView1.SelectedItems[0];
            List<ListViewItem> lvItems = new List<ListViewItem>();

            foreach (ListViewItem selectedItem in listView1.SelectedItems)
            {
                if (selectedItem.SubItems.Count > 1)
                {
                    lvItems.Add(selectedItem);
                }
            }

            foreach (ListViewItem item in lvItems)
            {
                FileSystem.DeleteFile(item.SubItems[4].Text, UIOption.AllDialogs, RecycleOption.SendToRecycleBin, UICancelOption.DoNothing);
                item.SubItems[4].Text = "shell:RecycleBinFolder";
            }
        }

        private void moveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = listView1.SelectedItems[0];
            List<ListViewItem> lvItems = new List<ListViewItem>();
            
            foreach(ListViewItem selectedItem in listView1.SelectedItems)
            {
                if (selectedItem.SubItems.Count > 1)
                {
                    lvItems.Add(selectedItem);
                }
            }

            CommonFileDialog dialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                RestoreDirectory = true,
                DefaultDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                foreach(ListViewItem item in lvItems)
                {
                    File.Move(item.SubItems[4].Text, Path.Combine(dialog.FileName, item.Text));
                    item.SubItems[4].Text = Path.Combine(dialog.FileName, item.Text);
                }                
            }
        }

        private void fileLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = listView1.SelectedItems[0];
            if (!lvi.SubItems[4].Text.Contains("shell:RecycleBinFolder"))
                Process.Start("explorer.exe", "/select,\"" + lvi.SubItems[4].Text + "\"");
            else
                Process.Start("explorer.exe", $"/n, {lvi.SubItems[4].Text}");
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem lvi = listView1.SelectedItems[0];
                RenameFileUpdateSelectedListItem(lvi);
            }
            catch (Exception ex) { }
        }

        private void filenameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = listView1.SelectedItems[0];
            Clipboard.SetText(lvi.Text);
        }

        private void hashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = listView1.SelectedItems[0];
            Clipboard.SetText(lvi.SubItems[3].Text);
        }

        private void pathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = listView1.SelectedItems[0];
            Clipboard.SetText(lvi.SubItems[4].Text);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void howToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            howto frm = new howto();
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
