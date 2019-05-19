using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class Product
    {
        public int idProduct { get; set; }
        public string nameProduct { get; set; }
        public double price { get; set; }
        public int unitsInStock { get; set; }
        public int numCategory { get; set; }
        public string color { get; set; }
        public string model { get; set; }
        public string size { get; set; }
        public byte[] img { get; set; }
    }
}
