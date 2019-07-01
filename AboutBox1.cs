using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Library
{
    partial class AboutMenu : Form
    {
        public AboutMenu()
        {
            InitializeComponent();
            this.Text = String.Format("");
            this.labelProductName.Text = "My Library(Моя библиотека)";
            this.labelProductName.Font = new Font("Microsoft JhengHei", 10.5F);

            this.labelVersion.Text = "Версия 1.0 Beta";
            this.labelVersion.Font = new Font("Microsoft JhengHei", 10.5F);

            this.labelCopyright.Text = "Толстошеев Роман (Tolstosheyev Roman) aka IZOBRETATEL777";
            this.labelCopyright.Font = new Font("Microsoft JhengHei", 10.5F);

            this.labelCompanyName.Text = "IzobretatelSoft© 2019";
            this.labelCompanyName.Font = new Font("Microsoft JhengHei", 10.5F);

            this.textBoxDescription.Text = "Моя библиотека - универсальная и инновационная программа для администрирования Вашей библиотеки. Современный дизайн и интуитивно понятный дизайн обеспечивают быстрое и легкое управление данными о Вашей библиотеке. Подробнее о функционале в разделе помощь. Приятного чтения!";
            this.textBoxDescription.Font = new Font("Microsoft JhengHei", 12);
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void AboutMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
