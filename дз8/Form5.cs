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
    public partial class Form5 : Form
    {
        public string path;
        public Form5(string openPath)
        {
            InitializeComponent();
            path = openPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(path);
            writer.Write(textBox1.Text);
            writer.Close();
            DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            DialogResult = DialogResult.OK;
        }
    }
}
