using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class fAdmin : Form

    {

        public fAdmin()
        {
            InitializeComponent();

            LoadDateTimePicker();
            LoadListCateGory();
            LoadListByDate(dateTimePicker1.Value, dateTimePicker2.Value);
            LoadCategoryIntoCombobox(FoodCategory);
            dataGridView2.DataSource = DAO.Food.Instance.GetListFood();
            AddFoodBinding();
            AddCateBinding();
            
        }

        void LoadDateTimePicker()
        {
            DateTime today = DateTime.Now;
            dateTimePicker1.Value = new DateTime(today.Year, today.Month, 1);
            dateTimePicker2.Value = dateTimePicker2.Value.AddMonths(1).AddDays(-1);
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }
        void LoadListByDate(DateTime checkIn,DateTime checkOut)
        {
            dataGridView1.DataSource = DAO.Bill.Instance.GetBillListByDate(checkIn, checkOut);
        }
        private void Report_Click(object sender, EventArgs e)
        {
            LoadListByDate(dateTimePicker1.Value, dateTimePicker2.Value);
        }
        void AddFoodBinding()
        {
            FoodName.DataBindings.Add(new Binding( "Text",dataGridView2.DataSource, "NAME",true,DataSourceUpdateMode.Never));
            IDfood.DataBindings.Add(new Binding("Text", dataGridView2.DataSource, "ID",true, DataSourceUpdateMode.Never));
            numberricFood.DataBindings.Add(new Binding("Value", dataGridView2.DataSource, "PRICE", true, DataSourceUpdateMode.Never)); 
            
        }
        void AddCateBinding()
        {
            CateID.DataBindings.Add(new Binding("Text", dataGridView3.DataSource, "ID", true, DataSourceUpdateMode.Never));
            CateName.DataBindings.Add(new Binding("Text", dataGridView3.DataSource, "NAME", true, DataSourceUpdateMode.Never));
        }
        
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = DAO.Category.Instance.GetCategories();
            cb.DisplayMember = "NAME";
        }
        void LoadListFood()
        {
            dataGridView2.DataSource = DAO.Food.Instance.GetListFood();
        }
        private void LoadFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        private void IDfood_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 0)
            {
                int id = (int)dataGridView2.SelectedCells[0].OwningRow.Cells["IdCategory"].Value;
                DTO.Category category = DAO.Category.Instance.GetCategoryByID(id);
                FoodCategory.SelectedItem = category;
                int index = -1;
                int i = 0;
                foreach (DTO.Category item in FoodCategory.Items)
                {
                    if (item.Id == category.Id)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                FoodCategory.SelectedIndex = index;
            }
        }
        #region Food
        private void AddFood_Click(object sender, EventArgs e)
        {
            string name = FoodName.Text;
            int categoryID = (FoodCategory.SelectedItem as DTO.Category).Id;
            float price = (float)numberricFood.Value;
            if (DAO.Food.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Add food successfully!");
                LoadListFood();
                if (insertFood != null)
                    insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Fail to add food! Please try again.");
            }
        }

        private void EditFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDfood.Text);
            string name = FoodName.Text;
            int categoryID = (FoodCategory.SelectedItem as DTO.Category).Id;
            float price = (float)numberricFood.Value;
            if (DAO.Food.Instance.EditFood(id,name, categoryID, price))
            {
                MessageBox.Show("Update food successfully!");
                LoadListFood();
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Fail to update food! Please try again.");
            }
        }

        private void DeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDfood.Text);
            if (DAO.Food.Instance.DeleteFood(id))
            {
                MessageBox.Show("Delete food successfully!");
                LoadListFood();
                if (removeFood != null)
                    removeFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Fail to delete food! Please try again.");
            }
        }
        #endregion
        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }
        private event EventHandler removeFood;
        public event EventHandler RemoveFood
        {
            add { removeFood += value; }
            remove { removeFood -= value; }
        }
        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }
        List<DTO.Food> SearchFoodByName(string name)
        {
            List<DTO.Food> listFood = DAO.Food.Instance.SearchFoodByName(name);
            return listFood;
        }
        private void FindFood_Click(object sender, EventArgs e)
        {
           dataGridView2.DataSource= SearchFoodByName(Findtxt.Text);
        }
        #region CATEGORY
        void LoadListCateGory()
        {
            dataGridView3.DataSource = DAO.Category.Instance.GetCategories();
        }
        private void CateLoad_Click(object sender, EventArgs e)
        {
            LoadListCateGory();
        }
        private void CateAdd_Click(object sender, EventArgs e)
        {
            string name = CateName.Text;
            if (DAO.Category.Instance.InsertCate(name))
            {
                MessageBox.Show("Add Category successfully!");
                LoadListCateGory();
                if (insertCate != null)
                    insertCate(this, new EventArgs());
            }
            else MessageBox.Show("Fail to add Category! Please try again.");
        }
        private void CateEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(CateID.Text);
            string name = CateName.Text;
            if (DAO.Category.Instance.EditCate(id, name))
            {
                MessageBox.Show("Edit Category successfully!");
                LoadListCateGory();
                if (updateCate != null)
                    updateCate(this, new EventArgs());
            }
            else MessageBox.Show("Fail to edit Category! Please try again.");
        }
        private void CateDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(CateID.Text);
            if (DAO.Category.Instance.DeleteCate(id))
            {
                MessageBox.Show("Delete Category successfully!");
                LoadListCateGory(); 
                if (removeCate != null)
                    removeCate(this, new EventArgs());
            }
            else MessageBox.Show("Fail to delete Category! Please try again.");
        }
        private event EventHandler insertCate;
        public event EventHandler InserCate
        {
            add { insertCate += value; }
            remove { insertCate -= value; }
        }
        private event EventHandler removeCate;
        public event EventHandler RemoveCate
        {
            add { removeCate += value; }
            remove { removeCate -= value; }
        }
        private event EventHandler updateCate;
        public event EventHandler UpdateCate
        {
            add { updateCate += value; }
            remove { updateCate -= value; }
        }

        #endregion

    }
}

