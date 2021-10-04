using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    public class billinfo
    {
        private static billinfo instance;

        public static billinfo Instance {
            get { if (instance == null) instance = new billinfo();return instance; }
            private set { instance = value; }
        }
        private billinfo() { }
        public void DeleteBillInfobyFoodID(int id)
        {
             DAO.DataProvider.Instance.ExcuteQuery("DELETE FROM dbo.BillInfo WHERE IDFOOD =" + id);
        }
        public List<DTO.BillInfo> GetListBillInfo(int id)
        {
            List<DTO.BillInfo> listbillIfo = new List<DTO.BillInfo>();
            DataTable data = DAO.DataProvider.Instance.ExcuteQuery("SELECT* FROM dbo.BillInfo WHERE IDBILL =" + id);
            foreach (DataRow item in data.Rows)
            {
                DTO.BillInfo info = new DTO.BillInfo(item);
                listbillIfo.Add(info);
            }
            return listbillIfo;
        }
        public void Insert_BillInfo(int idbill,int idfood,int count) 
        {
            DAO.DataProvider.Instance.ExcurNonQuery("EXEC USP_InsertBillInfo @idBill  , @idFood  , @count ", new object[] { idbill ,idfood , count });
        }
    }
}
