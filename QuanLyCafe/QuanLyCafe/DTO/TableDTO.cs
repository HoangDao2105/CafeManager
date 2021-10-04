using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class TableDTO
    {
        public TableDTO(int id,string tablename,string status)
        {
            this.ID = id;
            this.NameTable = tablename;
            this.Stt = status;
        }
        public TableDTO(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.NameTable = row["NAME"].ToString();
            this.Stt = row["STATUS"].ToString();
        }
        private int iD;
        private string nameTable;
        private string stt;

        public int ID { get => iD; set => iD = value; }
        public string NameTable { get => nameTable; set => nameTable = value; }
        public string Stt { get => stt; set => stt = value; }
    }
}
