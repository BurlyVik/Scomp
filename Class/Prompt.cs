using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace scomp
{
    public partial class Prompt : Form
    {
        public string NewFileName { get; private set; }
        private string OldFileName { get; set; }
        public Prompt(string oldFileName)
        {
            InitializeComponent();
            this.OldFileName = oldFileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Prompt_Load(object sender, EventArgs e)
        {
            txbRename.Text = this.OldFileName;
            txbRename.Font = new Font(txbRename.Font, FontStyle.Italic);
            txbRename.Select(0, txbRename.Text.Length);
        }

        private void txbRename_TextChanged(object sender, EventArgs e)
        {
            txbRename.ForeColor = Color.Cyan;
            txbRename.Font = new Font(txbRename.Font, FontStyle.Regular);
        }

        private void txbRename_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
        }

        private void Prompt_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txbRename.Text.Length.Equals(0))
                this.NewFileName = this.OldFileName;
            else
                this.NewFileName = txbRename.Text;
        }
    }
}
