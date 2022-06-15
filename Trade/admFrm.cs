using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trade.Model;

namespace Trade
{
    public partial class admFrm : Form
    {
        public List<Product> product = new List<Product>(DBContext.db.Product);
        public admFrm()
        {
            InitializeComponent();
            GenerateData(product);
        }
        public void GenerateData(List<Product> product)
        {
            foreach (var a in product)
            {
                tovarUC card = new tovarUC();
                card.GenerateData(a);
                flowLayoutPanel1.Controls.Add(card);
            }
        }
        private void Poisk()
        {
            var listupdate = DBContext.db.Product.ToList();
            //поиск
            if (textBox1.Text != "Введите для поиска" && !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                listupdate = listupdate.Where(x => x.ProductName.ToLower().Contains(textBox1.Text.ToLower())).ToList();
            }
            //сортировка
            if (comboBox1.Text == "По стоимости")
            {
                if (!checkBox1.Checked)
                {
                    listupdate = listupdate.OrderBy(x => x.ProductCost).ToList();
                }
                else
                {
                    listupdate = listupdate.OrderByDescending(x => x.ProductCost).ToList();
                }
            }
            //фильтрация
            //if (comboBox2.Text == "0-9.99%")
            //{
            //    listupdate = listupdate.Where(x => x.ProductDiscountAmount ).ToList();
            //}

            flowLayoutPanel1.Controls.Clear();
            GenerateData(listupdate);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "Введите для поиска")
            {
                flowLayoutPanel1.Controls.Clear();
                Poisk();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Poisk();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Poisk();
        }
   

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Poisk();
        }
    }
}
