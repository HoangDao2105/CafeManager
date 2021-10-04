using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class Bill
    {
        private int iD;
        private int status;
        private DateTime? datecheckout;
        private DateTime? datecheckin;
        private int discount;

        public Bill(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Datecheckin = (DateTime?)row["DATECHECKIN"];
            var dateCheckOutTemp = row["DATECHECKOUT"];
            if (dateCheckOutTemp.ToString() != "")
                this.Datecheckout = (DateTime?)dateCheckOutTemp;
            this.Status = (int)row["STATUS"];
            this.Discount = (int)row["DISCOUNT"];

        }


        public Bill(int id, DateTime datecheckin, DateTime datecheckout, int status,int discount=0)
        {
            this.ID = id;
            this.Datecheckin = datecheckin;
            this.Datecheckout = datecheckout;
            this.Status = status;
            this.Discount = discount;

        }
        public DateTime? Datecheckout { get => datecheckout; set => datecheckout = value; }
        public DateTime? Datecheckin { get => datecheckin; set => datecheckin = value; }
        public int ID { get => iD; set => iD = value; }
        public int Status { get => status; set => status = value; }
        public int Discount { get => discount; set => discount = value; }
    }
}
