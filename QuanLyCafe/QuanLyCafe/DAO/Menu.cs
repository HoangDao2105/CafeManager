using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    public class Menu
    {
        private static Menu instance;

        public static Menu Instance {
            get { if (instance == null) instance = new Menu();return instance; }
            private set { instance = value; }
        }
        private Menu() { }
        public List<DTO.Menu> GetMenuListbyTable(int id)
        {
            List<DTO.Menu> list = new List<DTO.Menu>();
            DataTable data= DAO.DataProvider.Instance.ExcuteQuery("SELECT f.NAME,bi.COUNT,f.PRICE,f.PRICE*bi.COUNT AS TOTALPRICE FROM dbo.Bill AS b,dbo.BillInfo AS bi,dbo.Food AS f WHERE bi.IDBILL=b.ID AND bi.IDFOOD=f.ID AND b.IDTABLE= "+id+"AND STATUS=0 ");
            foreach (DataRow item in data.Rows)
            {
                DTO.Menu menu = new DTO.Menu(item);
                list.Add(menu);
            }
            return list; 
        }
    }
}
