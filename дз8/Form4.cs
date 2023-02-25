using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace дз8
{
    public partial class Form4 : Form
    {
        
        public string openPath="";
        public Form4()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files(*.txt)|*.txt";
            openFile.FilterIndex = 2;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                openPath = openFile.FileName;
            
            }
            button2.Enabled = true;
            textBox1.Text = openPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(openPath);
             OpenFileDialog openFile = new OpenFileDialog();
            StreamReader reader = File.OpenText(openPath);
            form5.textBox1.Text = reader.ReadToEnd();
            reader.Close();
            form5.ShowDialog();
               
            
        }
    }
}
