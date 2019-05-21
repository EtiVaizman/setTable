using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Order
    {
        public int idOrder { get; set; }
        public System.DateTime date { get; set; }
        public int idCustomer { get; set; }
        public int paymant { get; set; }
    }
}
