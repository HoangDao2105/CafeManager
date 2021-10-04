using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    public class Bill
    {
        private static Bill instance;

        public static Bill Instance {
            get { if (instance == null) instance = new Bill();return instance; }
            private set { instance = value; }
             }
        private Bill()
        {

        }
        public int GetUncheckBillByID(int id)
        {
            DataTable data = DAO.DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.Bill WHERE IDTABLE="+id+" AND STATUS=0");
            if (data.Rows.Count > 0)
            {
                DTO.Bill bill = new DTO.Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
        public void Insert_Bill(int id)
        {
            DAO.DataProvider.Instance.ExcurNonQuery("EXEC USP_InsertBill @idTable ", new object[] { id });
        }
        public int GetMaxIDBill()
        {
            try
            {
                return (int)DAO.DataProvider.Instance.ExcuteScalar("SELECT MAX(ID) FROM Bill");
            }
            catch
            {
                return 1;
            }
        }
        public void CheckOut(int id,int discount)
        {
            DAO.DataProvider.Instance.ExcurNonQuery("UPDATE dbo.Bill SET DATECHECKOUT=GETDATE(), STATUS = 1, "+"DISCOUNT="+discount+" WHERE ID = " + id);
        }
        public DataTable GetBillListByDate(DateTime checkin, DateTime checkout)
        {
            DataTable listbilldate = DAO.DataProvider.Instance.ExcuteQuery("EXEC dbo.USP_GetListByDate @checkIn , @checkOut ", new object[] { checkin, checkout });
            return listbilldate;
        }
    }
}
