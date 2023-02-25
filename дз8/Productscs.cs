using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз8
{
    public class Product
    {
        public decimal Cost { get; set; }
        public string Name { get; set; }
        public string[,] Complex { get; set; }
       // public string 

        public Product( string _name, decimal _cost, string[,] _comx)
        {
            Cost = _cost;
            Name = _name;
            Complex = _comx;
        }
       
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
