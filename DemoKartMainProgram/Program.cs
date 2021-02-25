using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoKartBL;

namespace DemoKart
{
    class Program
    {
       
        static List<Product> CList = new List<Product>(10);
        static List<Product> PList = new List<Product>(10);
            
         public void Display(int id)
        {
            foreach(Product item in ProductList)
            {
                if(id==item.category.categoryid)
                {
                    Console.WriteLine("Product id : " + item.Product_id + "\tProduct Name : " + item.Product_name + "\tProduct Price : " + item.Product_price + "\tProduct Quantity : " + item.Product_qty + "\tCategory Id : " + item.category.categorryid + "\tCategory Name : " + item.category.categoryname);
                }
            }
        }
         static void Main(string[] args)
        {
            Category CategoryObj = new Category();
            Cart CartObj = new Cart();
            Order OrderObj = new DemoKartBL.Order();
            Payment paymentObj = new Payment();
            User UserObj = new User();

            Console.Write("Enter the Username: ");
            String Username = Console.ReadLine();
            Console.Write("Enter the Password: ");
            String Password = Console.ReadLine();
            int value = UserObj.Login(UserName, Password);
            if (value == 1)
            {
                do
                {
                    Console.WriteLine("1.Electronics\t2.Grocery\t3.Clothing\t4.Cosmetics");
                    int Choice = Convert.ToInt32(Console.ReadLine());
                    if (Choice == 1)
                    {
                        programObj.Display(Choice);
                        Console.WriteLine("1.Add To Cart\t2.Continue");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        if (num1 == 1)
                        {
                            Console.WriteLine("\nEnter ID's of Product You Want Add to Cart : ");
                            id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nEnter How Many Quantity You Want");
                            int quant = Convert.ToInt32(Console.ReadLine());
                            foreach (Product item in ProductList)
                            {
                                if (id == item.productId)
                                {
                                    value = CartObj.AddToCart(quant);
                                    if (value == 1)
                                    {
                                        Console.WriteLine("Quantity Size Exceed The Limit\n");
                                        break;
                                    }
                                    else
                                    {
                                        double TotalPric = CategoryObj.CalculatePrice(Choice, item.price, quant);
                                        TotalPrice1 = TotalPrice1 + TotalPric;
                                        Product cust_cart = new Product(item.productId, item.productName, item.price, quant, item.CategoryObj.categoriesId, item.CategoryObj.categories);
                                        CartList.Add(cust_cart);
                                        Console.WriteLine("Add To cart Is Successfull\n");
                                    }

                                }
                            }

                        }
                    }
        }
    }
}
