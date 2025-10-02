using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tuan3_2011068465
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var date = DateTime.Now.ToString("dd/MM/yyyy");
            var time = DateTime.Now.ToString("hh:mm:ss tt");
            this.toolStripStatusLabel1.Text = string.Format($"Hom nay la ngay: {date} - {time}");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Video Files | *.mp4";
            if (ofd.ShowDialog()== DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = ofd.FileName;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
