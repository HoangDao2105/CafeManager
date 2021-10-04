using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        bool Login(string username,string password)
        {

            return DAO.AccountDAO.Instance.Login(username, password);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (Login(username,password))
            {
                DTO.Account loginAccount = DAO.AccountDAO.Instance.GetAccountByUsername(username);
                fManagement f = new fManagement(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Wrong usernam or password! Please try again!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Do you want to exit program?","Are you sure?", MessageBoxButtons.YesNoCancel) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
