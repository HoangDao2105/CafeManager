using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class BillInfo
    {
        private int iD;
        private int coutFood;
        private int iDFood;
        private int iDBill;

        public BillInfo(int id,int idFood,int idBill,int coutFood)
        {
            this.ID = id;
            this.IDFood = idFood;
            this.IDBill = idBill;
            this.CoutFood = coutFood;
        }
        public BillInfo(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.IDBill=(int)row["IDBILL"];
            this.IDFood = (int)row["IDFOOD"];
            this.CoutFood = (int)row["COUNT"];
        }
        public int ID { get => iD; set => iD = value; }
        public int CoutFood { get => coutFood; set => coutFood = value; }
        public int IDFood { get => iDFood; set => iDFood = value; }
        public int IDBill { get => iDBill; set => iDBill = value; }
    }
}
