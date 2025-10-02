using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02_tuan3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbFontSize.SelectedIndex = 4;
            LoadFontChu();
        }


        private void LoadFontChu()
        {
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                cbbFont.Items.Add(font.Name);
            }
            cbbFont.SelectedItem = "Times New Roman";
        }

        private void cbbFont_TextChanged(object sender, EventArgs e)
        {
            string fontNew = cbbFont.Text;
            float fontSize = float.Parse(cbbFontSize.Text);
            richTextBox1.Font = new Font(fontNew,fontSize,FontStyle.Regular);  // 1; tên font. 2; kích thước chữ. 3; định dạng
        }
    }
}
