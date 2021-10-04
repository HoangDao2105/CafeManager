using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    public class Category
    {
        private static Category instance;

        public static Category Instance {
            get { if (instance == null) instance = new Category();return instance; }
            private set { instance = value; }
        }
        private Category() { }
        public List<DTO.Category> GetCategories()
        {
            List<DTO.Category> list = new List<DTO.Category>();
            DataTable data = DAO.DataProvider.Instance.ExcuteQuery("SELECT* FROM dbo.Category");
            foreach (DataRow item in data.Rows)
            {
                DTO.Category category = new DTO.Category(item);
                list.Add(category);
            }
            return list;
        }

        public DTO.Category GetCategoryByID(int id)
        {
            DTO.Category category = null;
            DataTable data = DAO.DataProvider.Instance.ExcuteQuery("SELECT* FROM dbo.Category WHERE ID="+id);
            foreach (DataRow item in data.Rows)
            {
                category = new DTO.Category(item);
                return category;
            }

            return category;
        }
        public bool InsertCate(string name)
        {
            string query = string.Format("INSERT dbo.CATEGORY(NAME) VALUES( N'{0}' )", name);
            int result = DAO.DataProvider.Instance.ExcurNonQuery(query);
            return result > 0;
        }
        public bool EditCate(int id, string name)
        {
            string query = string.Format("UPDATE dbo.CATEGORY SET NAME=N'{0}'  WHERE ID={1}", name, id);
            int result = DAO.DataProvider.Instance.ExcurNonQuery(query);
            return result > 0;
        }
        public bool DeleteCate(int id)
        {
            DAO.Food.Instance.DeleteFoodByCateID(id);
            string query = string.Format("DELETE dbo.CATEGORY  WHERE ID={0}", id);
            int result = DAO.DataProvider.Instance.ExcurNonQuery(query);
            return result > 0;
        }
    }
}
