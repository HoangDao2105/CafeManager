using QuanLyCafe.DTO;
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
    public partial class AccountProfile : Form
    {
        private DTO.Account loginAccount;

        public Account LoginAccount { get { return loginAccount; } set { loginAccount = value; ChangeAccount(LoginAccount); } }

        public AccountProfile(DTO.Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
        }
        void ChangeAccount(DTO.Account loginAccount)
        {
            textBox1.Text = loginAccount.Username;
            textBox2.Text = loginAccount.Displayname;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        void UpdateAccount()
        {
            string username = textBox1.Text;
            string displayname = textBox2.Text;
            string password = textBox3.Text;
            string newpassword = textBox4.Text;
            string repassword = textBox5.Text;
            if (!repassword.Equals(newpassword))
            {
                MessageBox.Show("Please reenter your password match to your newpassword!");
            }
            else
            {
                if (DAO.AccountDAO.Instance.UpdateAccount(username, displayname, password, newpassword))
                {
                    MessageBox.Show("Upadate successfully!");
                }
                else
                {
                    MessageBox.Show("Please enter your password right!");
                }
            }
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            UpdateAccount();
            
        }
    }
}
