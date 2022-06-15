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

    public partial class Form1 : Form
    {
        Model1 db = new Model1();
        mainfrm man = new mainfrm();
        User User = new User();
        admFrm adm = new admFrm();
        clientFrm client = new clientFrm();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (loginTxBox.Text == "" || passTxBox.Text == "")
            {
                MessageBox.Show("Не все данные заполнены");
            }
            foreach (User User in db.User)
            {
                if ((User.UserLogin == loginTxBox.Text) && (User.UserPassword == passTxBox.Text))
                {
                    if (User.UserRole == 2)
                    {
                        man.Show();
                        this.Hide();
                        return;
                    }
                    else if (User.UserRole == 1)
                    {
                        client.Show();
                        return;
                    }
                    else if (User.UserRole == 3)
                    {
                        adm.Show();
                        return;
                    }
                }
            }

            if ((User.UserLogin != loginTxBox.Text) || (User.UserPassword != passTxBox.Text))
            {
                MessageBox.Show("Логин или пароль неверны");
                return;
            }
        }
    }
}

