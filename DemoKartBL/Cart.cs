using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    public class Cart
    {
       
        public int Product_id;
        public String Product_name;
        public int Product_qty;
        public decimal Product_price;



        public Cart(String prod_name, int prod_id, int prod_qty, decimal prod_price)
        {
            this.Product_name = prod_name;
            this.Product_id = prod_id;
            this.Product_qty = prod_qty;
            this.Product_price = prod_price;
        }

    }
}
