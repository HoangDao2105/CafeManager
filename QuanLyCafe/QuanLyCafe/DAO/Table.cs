using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    public class Table
    {
        private static Table instance;

        public static Table Instance {
            get { if (instance == null) instance = new Table(); return instance; }
            private set { instance = value; }
        }
        public static int tableHeight = 100;
        public static int tableWidth = 100;
        private Table() { }
        public List<DTO.TableDTO> LoadTableList()
        {
            List<DTO.TableDTO> tablelist = new List<DTO.TableDTO>();
            DataTable data = DAO.DataProvider.Instance.ExcuteQuery("EXEC dbo.USP_GetTableList");
            foreach (DataRow item in data.Rows)
            {
                DTO.TableDTO table = new DTO.TableDTO(item);
                tablelist.Add(table);
            }
            return tablelist;
        }
        public void SwitchTable(int id1, int id2)
        {
            DAO.DataProvider.Instance.ExcuteQuery("EXEC dbo.USP_SwitchTable @idTable1 , @idTable2", new object[] { id1,id2});
        }
    }
}
