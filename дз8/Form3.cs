using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace дз8
{
    public partial class Form3 : Form
    {
        public Product product = null;
        public int index = 0;

        public Form3( Product _product)
        {
            product = _product;
            InitializeComponent();
            ShowNow(product);
            index = product.Complex.Length / 3;
            
        }
        public void ShowNow(Product product)
        {
            textBox1.Text = product.Name;

            for (int i = 0; i < product.Complex.Length / 3; i++)
            {
                if (product.Complex[i, 0] == "") continue;
                listBox1.Items.Add(product.Complex[i, 0]);
               
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("You must select an item to edit it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBox2.Text = product.Complex[listBox1.SelectedIndex, 1];
                textBox3.Text = product.Complex[listBox1.SelectedIndex, 2] + "грн";
              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("You must select an item to edit it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            product.Cost -= Convert.ToDecimal(product.Complex[listBox1.SelectedIndex, 2]);
            string[,] a = product.Complex;

            int k = 0;
            for (int i = 0; i < index; i++)
            {

                if(i== listBox1.SelectedIndex)
                {
                    
                    continue;
                }
                else
                {
             
                    a[k, 0] = product.Complex[i, 0];
                    a[k, 1] = product.Complex[i, 1];
                    a[k, 2] = product.Complex[i, 2];
                   
                    k++;
                    
                }
               
            }
            a[k, 0] = "";
            a[k, 1] = "";
            a[k, 2] = "";
            index--;
            Product pd = new Product(product.Name,product.Cost, a);
            product = pd;
            listBox1.Items.Clear();
            ShowNow(product);
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           
            DialogResult =DialogResult.OK;
        }
    }
}
