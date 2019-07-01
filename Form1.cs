using System;
using System.Windows.Forms;
using System.IO;
using WPFCustomMessageBox;
using System.Windows;
using MessageBox = System.Windows.Forms.MessageBox;

namespace My_Library
{
    public partial class StartPage : Form
    {
        public StartPage()
        {

            InitializeComponent();

        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool OtherStuff_Button_Clicked = false;
        private void OtherStuff_Button_Click(object sender, EventArgs e)
        {
            if (OtherStuff_Button_Clicked == false)
            {
                OtherStuff_menu.Show(OtherStuff_Button, 1, OtherStuff_Button.Height);
                OtherStuff_Button_Clicked = true;
            }
            else
            {
                OtherStuff_menu.Hide();
                OtherStuff_Button_Clicked = false;
            }

        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutMenu current = new AboutMenu();
            current.ShowDialog();
        }

        private void ОтчиститьБазуДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CustomMessageBox.ShowOKCancel("Вы действительно хотите безвозвратно удалить базу данных Вашей библиотеки?", "Предупреждение", "Удалить", "Отменить") == MessageBoxResult.OK)
            {
                NPOImethods methods = new NPOImethods();
                methods.CreateBlank();
                MessageBox.Show("База данных удалена");
            }
            else
                MessageBox.Show("База данных не удалена");

        }

        private void BeSafe(object sender, EventArgs e)
        {
            Parametrs parametrs = new Parametrs();
            if (File.Exists(parametrs.path) == false)
            {
                NPOImethods methods = new NPOImethods();
                methods.CreateBlank();
            }
        }

        private void ShowDataTable_button_Click(object sender, EventArgs e)
        {
            Enabled = false;
            ShowDataTable dataTable = new ShowDataTable();
            dataTable.ShowDialog();
            Enabled = true;
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.ShowNewFolderButton = true;
            FBD.Description = "Укажите путь для сохранения";
            string fileName = "\\Library";
            string number = "1";
            string ext = ".xlsx";
            int n = 2;
            FBD.ShowDialog();
            while(File.Exists(@FBD.SelectedPath + fileName + number + ext))
            {
                number = $"{n}";
                n++;
            }
            Parametrs parametrs = new Parametrs();
            File.Copy(parametrs.path, @FBD.SelectedPath + fileName + number + ext);
        }


        private void AddBook_button_Click(object sender, EventArgs e)
        {
            AddNewBook curent = new AddNewBook();
            Enabled = false;
            curent.ShowDialog();
            Enabled = true;
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; ;
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void StartPage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
