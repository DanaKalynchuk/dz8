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
    public partial class Form2 : Form
    {
        
        Product p = null;

        Product pr = new Product("Ноутбук", 23945, new string[,] { { "Мишка", "Характкристика1", "600" }, { "Чохол","характеристика2","500" } });
        Product pr1 = new Product("Комп'ютер", 40000, new string[,] {{ "Мишка", "Характкристика1", "700" },
                                                                     { "Клавіатура","Характкристика3", "100" },
                                                                     { "Монітор","Характкристика4", "1600" } });
        Product pr2 = new Product("Пpинтер", 5999, new string[,] { {"Кабель","Характкристика5", "100" },
                                                                    { "Фарби","Характкристика6", "400" },
                                                                     { "Папір","Характкристика7", "300" }, });
       
        public Form2()
        {
            InitializeComponent();
            comboBox1.Items.Add(pr);
            comboBox1.Items.Add(pr1);
            comboBox1.Items.Add(pr2);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            p = (Product)comboBox1.SelectedItem;
            textBox1.Text = Convert.ToString(p.Cost);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal al = 0;
            foreach (var item in listBox1.Items)
            {
                p = (Product)item;
                al += p.Cost;
            }
            MessageBox.Show($"До сплати {al} грн");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("You must select an item to edit it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            p = (Product)comboBox1.SelectedItem;
            Form3 form = new Form3( p );
            form.ShowDialog();
            
            textBox1.Text = p.Cost.ToString();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("You must select an item to edit it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listBox1.Items.Add(comboBox1.SelectedItem);
        }
    }
}
