using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    public class Food
    {
        private static Food instance;

        public static Food Instance {
            get { if (instance == null) instance = new Food();return instance; }
            private set { instance = value; }
        }
        private Food() { }
        public List<DTO.Food> GetFoodsByCategoryID(int id)
        {
            List<DTO.Food> list = new List<DTO.Food>();
            DataTable data = DAO.DataProvider.Instance.ExcuteQuery("SELECT* FROM dbo.Food WHERE IDCATEGORY= "+id);
            foreach (DataRow item in data.Rows)
            {
                DTO.Food food = new DTO.Food(item);
                list.Add(food);
            }
            return list;
        }
        public List<DTO.Food> GetListFood()
        {
            List<DTO.Food> list = new List<DTO.Food>();
            DataTable data = DAO.DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.Food");
            foreach (DataRow item in data.Rows)
            {
                DTO.Food food = new DTO.Food(item);
                list.Add(food);
            }
            return list;
        }
        public bool InsertFood(string name,int id,float price)
        {
            string query = string.Format("INSERT dbo.Food(NAME,IDCATEGORY,PRICE) VALUES( N'{0}',{1} ,{2} )",name,id,price);
            int result = DAO.DataProvider.Instance.ExcurNonQuery(query);
            return result > 0;
        }
        public bool EditFood(int id,string name, int idcategory, float price)
        {
            string query = string.Format("UPDATE dbo.Food SET NAME=N'{0}', IDCATEGORY={1} ,PRICE={2} WHERE ID={3}",name,idcategory,price,id);
            int result = DAO.DataProvider.Instance.ExcurNonQuery(query);
            return result > 0;
        }
        public bool DeleteFood(int id)
        {
            DAO.billinfo.Instance.DeleteBillInfobyFoodID(id);
            string query = string.Format("DELETE dbo.Food  WHERE ID={0}", id);
            int result = DAO.DataProvider.Instance.ExcurNonQuery(query);
            return result > 0;
        }
        public void DeleteFoodByCateID(int id)
        {
            DAO.DataProvider.Instance.ExcuteQuery("DELETE FROM dbo.Food WHERE IDCATEGORY =" + id);
        }
        public List<DTO.Food> SearchFoodByName(string name)
        {
            List<DTO.Food> list = new List<DTO.Food>();
            string query = string.Format("SELECT * FROM dbo.Food Where NAME like N'%{0}%'", name);
            DataTable data = DAO.DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DTO.Food food = new DTO.Food(item);
                list.Add(food);
            }
            return list;
        }
    }
}
