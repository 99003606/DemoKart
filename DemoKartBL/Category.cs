using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    
    public class Category
    {

        public static List<Product> PList = new List<Product>();
        public int categoryid;
        public string category_name;
       public Category(int categoryid, string category_name)
        {
            this.categoryid = categoryid;
            this.category_name = category_name;
        }

        PList.Add(new Product(1,"Electronics","TV", 1, 2, 20000 );
        PList.Add(new Product(1,"Electronics","Refrigerator", 2, 2, 20000 );
        PList.Add(new Product(1,"Electronics","Mobile", 3, 2, 10000 );
        PList.Add(new Product(1,"Electronics","Washing Machine", 4, 2, 20000 );
        PList.Add(new Product(2,"Grocery","Fruits", 5, 2, 100 );
        PList.Add(new Product(2,"Grocery","Buiscuits", 6, 2, 50 );
        PList.Add(new Product(2,"Grocery","Bread", 7, 2, 50 );
        PList.Add(new Product(2,"Grocery","Chocolate", 8, 2, 100 );
        PList.Add(new Product(3,"Clothes","Shirt", 9, 2, 500 );

        PList.Add(new Product(3,"Clothes","Pant", 10, 2, 600 );
        PList.Add(new Product(3,"Clothes","Tshirt", 11, 2, 500 );
        PList.Add(new Product(3,"Clothes","Tie", 12, 2, 300 );
        PList.Add(new Product(4,"Cosmetics","Cream", 13, 2, 50 );
        PList.Add(new Product(4,"Cosmetics","Deodrant", 14, 2, 50 );
        PList.Add(new Product(4,"Cosmetics","Facewash", 15, 2, 50 );
        PList.Add(new Product(4,"Cosmetics","Lipstick", 16, 2, 50 );
       


    }
   
}
