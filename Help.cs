using System;
using System.Windows.Forms;
using System.IO;

namespace My_Library
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            string curDir = Directory.GetCurrentDirectory();
            this.webBrowser1.Navigate(new Uri(String.Format("file:///{0}/HelpPage.html", curDir)));
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Button1_Click(sender, e);
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Help_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
