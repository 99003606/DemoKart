using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    
    public class Product
    {
        public Category category = new Category();
        public int Product_id;
        public String Product_name;
        public int Product_qty;
        public decimal Product_price;

        public Product(int categoryid, String category_name, String Product_name, int Product_id, int Product_qty, decimal Product_price)
        {
            category.category_id = categoryid;
            category.categoryname - category_name;
            this.Product_name = Product_name;
            this.Product_id = Product_id;
            this.Product_qty = Product_qty;
            this.Product_price = Product_price;

        }

}
