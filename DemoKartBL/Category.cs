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
        public int categoryid { get; set; }
        public String categoryname { get; set; }
        public double totalCost = 0;
        public Category(int categoryid, string category_name)
        {
            this.categoryid = categoryid;
            this.category_name = category_name;
        }

       public double CalculatePrice(int cat_gory, double cost,int Quantity)
        {
            if (cat_gory == 1)
            {
                cost = cost * Quantity;
                totalCost = cost + (cost * 0.18);
                return totalCost;
            }
            else if (cat_gory == 2)
            {
                cost = cost * Quantity;
                totalCost = cost + ( cost * 0.04);
                return totalCost;
            }
            else if (cat_gory == 3)
            {
                cost = cost * Quantity;
                totalCost = cost + (cost * 0.07);
                return totalCost;
            }
            else if (Cat_gory == 4)
            {
                cost = cost * Quantity;
                totalCost = cost + (cost * 0.18);
                return totalCost;
            }
            else
            {
                return 0;
            }
        }

    }
       


    }
   
}
