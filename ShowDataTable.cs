using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using WPFCustomMessageBox;
using MessageBox = System.Windows.Forms.MessageBox;

namespace My_Library
{
    public partial class ShowDataTable : Form
    {
        public ShowDataTable()
        {
            InitializeComponent();

        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void loadData()
        {
            Data.Rows.Clear();
            Data.Columns.Clear();
            NPOImethods methods = new NPOImethods();
            List<string[]> table = new List<string[]>();
            methods.GetStringArray(table);
            for (int i = 0; i < methods.ColumsCnt; i++)
                Data.Columns.Add(methods.header[i], methods.header[i]);
            foreach (string[] i in table)
                Data.Rows.Add(i);

            Data.BorderStyle = BorderStyle.None;
            Data.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            Data.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Data.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            Data.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            Data.BackgroundColor = Color.White;

            Data.EnableHeadersVisualStyles = false;
            Data.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Data.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            Data.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }
        private void ShowDataTable_Load(object sender, EventArgs e) 
        {
            loadData();
            Logo.Location = new System.Drawing.Point(this.Width / 2 - Logo.Width / 2, 9);
            Data.EnableHeadersVisualStyles = false;
            Data.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 20.25F);
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            Data.Rows.Clear();
            NPOImethods methods = new NPOImethods();
            
            List<string> keys = new List<string>();
            keys = textForSearch.Text.Split(' ').ToList();
            if (keys.Count == 0)
            {
                MessageBox.Show(text: "Введите данные для поиска");
            }
            else
            {
                HashSet<int> indexes = new HashSet<int>();
                indexes = methods.SearchElement(keys);
                if (indexes.Count == 0)
                {
                    MessageBox.Show(text: "Ничего не найдено!");
                    loadData();
                    
                }
                else
                    foreach (int index in indexes)
                        Data.Rows.Add(methods.GetRowByIndex(index));
            }
        }

        private void TextForSearch_Click(object sender, EventArgs e)
        {
            textForSearch.Clear();
        }
        private void SaveEdits_button_Click(object sender, EventArgs e)
        {
            SaveEdits();
        }
        private void Eidit_buttoon_Click(object sender, EventArgs e)
        {
            Data.ReadOnly = false;
            SaveEdits_button.Enabled = true;
            Abort_button.Enabled = true;
        }


        private void SaveEdits()
        {
            if (CustomMessageBox.ShowOKCancel("Вы действительно хотите сохранить изменения?", "Предупреждение", "Сохранить", "Отменить") == MessageBoxResult.OK)
            {
                NPOImethods methods = new NPOImethods();
                for (int i = 0; i < Data.Rows.Count; i++)
                {
                    string[] currentRow = new string[methods.ColumsCnt];
                    for (int j = 0; j < methods.ColumsCnt; j++)
                        currentRow[j] = Data.Rows[i].Cells[j].Value.ToString();

                    methods.SetNewValueInRow(currentRow, i + methods.startRow);
                }
                SaveEdits_button.Enabled = false;
                Abort_button.Enabled = false;
            }
            else
            {
                loadData();
            }
        }

        private void Abort_button_Click(object sender, EventArgs e)
        {
            if (CustomMessageBox.ShowOKCancel("Вы действительно хотите отменить изменения?", "Предупреждение", "Отменить", "Продолжить") == MessageBoxResult.OK)
                loadData();
        }

        private void Exit_lable_Click(object sender, EventArgs e)
        {
            Close_button_Click(sender, e);
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void ShowDataTable_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
