using System.Runtime.InteropServices;


namespace scomp
{
    public static class CenteredMessageBox
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr GetActiveWindow();

        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("user32.dll")]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        private const uint SWP_NOSIZE = 0x0001;
        private const uint SWP_NOZORDER = 0x0004;

        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            RECT parentRect;
            GetWindowRect(owner.Handle, out parentRect);

            int x = parentRect.Left + (parentRect.Right - parentRect.Left) / 2;
            int y = parentRect.Top + (parentRect.Bottom - parentRect.Top) / 2;

            IntPtr activeWindow = GetActiveWindow();

            DialogResult result = MessageBox.Show(owner, text, caption, buttons, icon);

            SetWindowPos(activeWindow, IntPtr.Zero, 0, 0, 0, 0, SWP_NOSIZE | SWP_NOZORDER);

            return result;
        }
    }
}
