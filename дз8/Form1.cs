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
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            listBox1.Items.Clear();
            folderBrowserDialog1.ShowDialog();
            string folder = folderBrowserDialog1.SelectedPath;
            foreach (var item in Directory.GetFiles(folder, textBox1.Text))
            {
                listBox1.Items.Add(item);
            }
          
        }
    }
}
