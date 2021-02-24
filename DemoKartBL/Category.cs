using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    public class Category
    {
        List<Category> CLst = new List<Category>();
        List<Product> PList = new List<Product>();

        public string ProductName{get;set;}

        public List<Category> getSetCategory
        {
            get { 
                return CLst; 
            }
            set { 
                CLst = value; 
            }
        }
        public List<Product> getsetProduct
        {
            get { 
                return PList; 
            }
            set { 
                PList = value; 
            }
        }
    }
   
}
