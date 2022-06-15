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
    public partial class tovarUC : UserControl
    {
        public tovarUC()
        {
            InitializeComponent();
        }
        public void GenerateData(Product a)
        {
            pictureBox1.ImageLocation = a.ProductPhoto;
            label1.Text = "Наименование: " + a.ProductName;
            label2.Text = "Описание товара: " + a.ProductDescription;
            label3.Text = "Производитель: " + a.ProductManufacture;
            label4.Text = "Цена: " + a.ProductCost;
            label5.Text = "Размер скидки:         " + "%";
            label7.Text = a.ProductDiscountAmount;
            if (label7.Text == "5")
            {
                panel4.BackColor = Color.Chartreuse;
            }
            if (label5.Text != null) //перерасчет стоимости
            {
                label4.Font = new Font(label4.Font.FontFamily, label4.Font.Size, FontStyle.Strikeout); //зачеркнутый текст
                int x = 0; //переменная для старой цены
                int y = 0; //размер скидки
                int z = 0; //новая цена
                x = Convert.ToInt32(a.ProductCost);
                y = Convert.ToInt32(a.ProductDiscountAmount);
                z = x - (x/100 * y); //формула скидки
                label6.Text = z.ToString(); //новая цена
            }
        }
    }
}
