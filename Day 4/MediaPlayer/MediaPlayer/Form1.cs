using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All Files (*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                string sFileName = op.FileName;
                string[] arrAllFiles = op.FileNames;
            }

            string fl = op.FileName;
            axWindowsMediaPlayer1.URL = fl;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
                
        }
    }
}
