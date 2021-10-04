using QuanLyCafe.DAO;
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

    public partial class fManagement : Form
    {

        private DTO.Account loginAccount;

        public Account LoginAccount {
            get { return loginAccount;}
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }

        public fManagement(DTO.Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            ChangeAccount(acc.Type);
            LoadTable();
            LoadCategory();
            LoadComBoBoxTable(listTable);
        }
        #region Methods
        void ChangeAccount(int type)
        { 
            
            adminToolStripMenuItem.Enabled = type == 1;
            userToolStripMenuItem.Text = "User (" + loginAccount.Displayname + ")";
        }
        void LoadCategory()
        {
            List<DTO.Category> list = DAO.Category.Instance.GetCategories();
            Catogory.DataSource = list;
            Catogory.DisplayMember = "NAME";
        }
        void LoadFoodListByCategoryID(int id)
        {
            List<DTO.Food> list = DAO.Food.Instance.GetFoodsByCategoryID(id);
            Food.DataSource = list;
            Food.DisplayMember = "NAME";
        }
        void LoadTable()
        {
            flowLayoutPanel1.Controls.Clear();
            List<DTO.TableDTO> tablelist = DAO.Table.Instance.LoadTableList();
            foreach (DTO.TableDTO item in tablelist)
            {
                Button btn = new Button() { Width = DAO.Table.tableWidth, Height = DAO.Table.tableHeight };
                btn.Text = item.NameTable+"\n"+item.Stt;
                btn.Click += Btn_Click;
                btn.Tag = item;
                switch (item.Stt)
                {
                    case "EMPTY":
                        btn.BackColor = Color.Green;
                        break;
                    default:
                        btn.BackColor = Color.Red;
                        break;
                }
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        void ShowBill(int id)
        {
            ListBill.Items.Clear();
            float totalprice = 0;
            List<DTO.Menu> menus = DAO.Menu.Instance.GetMenuListbyTable(id);
            foreach (DTO.Menu item in menus)
            {
                ListViewItem lvit = new ListViewItem(item.FoodName.ToString());
                lvit.SubItems.Add(item.Count.ToString());
                lvit.SubItems.Add(item.Price.ToString());
                lvit.SubItems.Add(item.TotalPrice.ToString());
                totalprice += item.TotalPrice;
                ListBill.Items.Add(lvit);

            }
            PriceTxt.Text = totalprice.ToString("c");
            
        }
        void LoadComBoBoxTable(ComboBox cb)
        {
            cb.DataSource = DAO.Table.Instance.LoadTableList();
            cb.DisplayMember = "ID";
        }
        #endregion
        #region Events
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as DTO.TableDTO).ID;
            ListBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        private void ListBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DTO.TableDTO table = ListBill.Tag as DTO.TableDTO;
            if (table == null)
            {
                MessageBox.Show("Select Table!");
                return;
            }
            int idBill = DAO.Bill.Instance.GetUncheckBillByID(table.ID);
            int idFood = (Food.SelectedItem as DTO.Food).Id;
            int count = (int)numberFood.Value;
            if (idBill == -1)
            {
                DAO.Bill.Instance.Insert_Bill(table.ID);
                DAO.billinfo.Instance.Insert_BillInfo(DAO.Bill.Instance.GetMaxIDBill(),idFood,count);
            }
            else
            {
                DAO.billinfo.Instance.Insert_BillInfo(idBill, idFood, count);
                
            }
            ShowBill(table.ID);
            LoadTable();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void infomationsUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountProfile info = new AccountProfile(loginAccount);
            info.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin a = new fAdmin();
            a.InsertFood += A_InsertFood;
            a.UpdateFood += A_UpdateFood;
            a.RemoveFood += A_RemoveFood;
            a.ShowDialog();
        }

        private void A_RemoveFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((Catogory.SelectedItem as DTO.Category).Id);
            if(ListBill.Tag!=null)
                ShowBill((ListBill.Tag as DTO.TableDTO).ID);
            LoadTable();
        }

        private void A_UpdateFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((Catogory.SelectedItem as DTO.Category).Id);
            if (ListBill.Tag != null)
                ShowBill((ListBill.Tag as DTO.TableDTO).ID);
        }

        private void A_InsertFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((Catogory.SelectedItem as DTO.Category).Id);
            if (ListBill.Tag != null)
                ShowBill((ListBill.Tag as DTO.TableDTO).ID);
        }

        private void Catogory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            DTO.Category cate = cb.SelectedItem as DTO.Category;
            id = cate.Id;
            LoadFoodListByCategoryID(id);
        }
        private void Paybtn_Click(object sender, EventArgs e)
        {
            DTO.TableDTO table = ListBill.Tag as DTO.TableDTO;
            int idbill = DAO.Bill.Instance.GetUncheckBillByID(table.ID);
            int discount = Convert.ToInt32(numberDiscount.Value.ToString());
            double totalPrice = Convert.ToDouble(PriceTxt.Text.Split(',')[0]);
            double finalPrice = totalPrice - (totalPrice / 100) * discount;
            if (idbill == -1)
                return;
            else
            {
                if (MessageBox.Show(string.Format("Do you want to pay your bill?{0}\nPay - Pay x Discount = {1} - ({1}/100)x{2}={3}", table.NameTable, totalPrice, discount, finalPrice), "Are you sure ?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    DAO.Bill.Instance.CheckOut(idbill, discount);
                    ShowBill(table.ID);
                    LoadTable();
                }

            }
        }

        private void switchTable_Click(object sender, EventArgs e)
        {
            
            int id1 = (ListBill.Tag as DTO.TableDTO).ID;
            int id2 = (listTable.SelectedItem as DTO.TableDTO).ID;
            if (MessageBox.Show(string.Format("Do you want to switch {0} to {1}", id1, id2),"Are you sure?",MessageBoxButtons.YesNo)==System.Windows.Forms.DialogResult.Yes)
                DAO.Table.Instance.SwitchTable(id1, id2);
            LoadTable();
        }


        #endregion

        private void payToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paybtn_Click(this, new EventArgs());
        }
    }
}
