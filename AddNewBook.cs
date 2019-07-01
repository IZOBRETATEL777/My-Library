using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace My_Library
{
    public partial class AddNewBook : Form
    {
        public AddNewBook()
        {
            InitializeComponent();
        }

        private List<TextBox> TextboxList = new List<TextBox>();
        private List<Label> LabelList = new List<Label>();

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            NPOImethods file = new NPOImethods();
            string[] book = new string[file.ColumsCnt];
            for (int i = 0; i < TextboxList.Count; i++)
            {
                book[i] = TextboxList[i].Text.ToString();
                if ((i == file.BookNameRow || i == file.AuthorRow) && (book[i] == "*" || book[i] == ""))
                {
                    MessageBox.Show(caption: "Внимание!", text: "Не все основные поля заполнены", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
                    return;
                }
            }
            book[TextboxList.Count] = (InLibrary_chkbox.Checked ? "Да" : "Нет");
            FormatInput formatInput = new FormatInput();
            file.Add(formatInput.format(book));
            MessageBox.Show(text: "Добавлено!", caption:"Статус", buttons: MessageBoxButtons.OK, icon:MessageBoxIcon.Information);
            for (int i = 0; i < TextboxList.Count; i++)
            {
                if (i == file.BookNameRow || i == file.AuthorRow)
                    TextboxList[i].Text = "*";
                else
                    TextboxList[i].Clear();
            }
            InLibrary_chkbox.Checked = false;

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddNewBook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddBookButton.PerformClick();
            if (e.KeyCode == Keys.Escape)
                CloseButton.PerformClick();
        }

        private void AddNewBook_Load(object sender, EventArgs e)
        {

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textbox = control as TextBox;
                    TextboxList.Add(textbox);
                }
                if (control is Label)
                {
                    Label lable = control as Label;
                    LabelList.Add(lable);
                }
            }
            TextboxList.Reverse();
            LabelList.Reverse();
            Parametrs parametrs = new Parametrs();
            /*
            for (int i = 0; i < LabelList.Count; i++)
                LabelList[i].Text = parametrs.header[i];
            */
            for (int i = 0; i < TextboxList.Count; i++)
            {
                if (i == parametrs.BookNameRow || i == parametrs.AuthorRow)
                    TextboxList[i].Text = "*";
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        bool InLibrary = false;
        private void InLibrary_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            InLibrary = InLibrary_chkbox.Checked = !InLibrary;

        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void AddNewBook_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
