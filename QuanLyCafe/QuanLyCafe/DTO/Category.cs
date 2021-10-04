using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class Category
    {
        public Category(int id,string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public Category(DataRow rows)
        {
            this.Id = (int)rows["ID"];
            this.Name = rows["NAME"].ToString();
        }
        private string name;
        private int id;

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
    }
}
