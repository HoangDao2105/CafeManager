using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class Food
    {
        public Food(int id,string name,int idcategory,float price)
        {
            this.Id = id;
            this.Name = name;
            this.IdCategory = idcategory;
            this.Price = price;
        }
        public Food(DataRow rows)
        {
            this.Id = (int)rows["ID"];
            this.Name = rows["NAME"].ToString();
            this.IdCategory = (int)rows["IDCATEGORY"];
            this.Price = (float)Convert.ToDouble(rows["PRICE"].ToString());
        }
        private int id;
        private string name;
        private int idCategory;
        private float price;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int IdCategory { get => idCategory; set => idCategory = value; }
        public float Price { get => price; set => price = value; }
    }
}
