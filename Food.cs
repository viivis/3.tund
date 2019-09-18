using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esimenetund
{
    public class Food
    {
        public string Name { get; set; }//getiga saame väärtuse, setiga omistame väärtuse

        public double Price { get; set; }

        public Food(string name, double price ) //konstruktor loob uue objekti
        {
            this.Name = name;
            this.Price = price;

        }   

    }
}
