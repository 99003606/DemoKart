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
                                        Product cust_cart = new Product(item.Product_id, item.Product_name, item.Product_price, Product_qty, item.category.categoryid, item.category.categoryname);
                                        CartList.Add(cust_cart);
                                        Console.WriteLine("Add To cart Is Successfull\n");
                                    }

                                }
                            }

                        }
                    }
                     if (Choice == 2)
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
                                        Product cust_cart = new Product(item.Product_id, item.Product_name, item.Product_price, Product_qty, item.category.categoryid, item.category.categoryname));
                                        CartList.Add(cust_cart);
                                        Console.WriteLine("Add To cart Is Successfull\n");
                                    }

                                }
                            }

                        }
                    }
                    if (Choice == 3)
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
                                        Product cust_cart = new Product(item.Product_id, item.Product_name, item.Product_price, Product_qty, item.category.categoryid, item.category.categoryname));
                                        CartList.Add(cust_cart);
                                        Console.WriteLine("Add To cart Is Successfull\n");
                                    }

                                }
                            }

                        }
                    }
                    if (Choice == 4)
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
                                        Product cust_cart = new Product(item.Product_id, item.Product_name, item.Product_price, Product_qty, item.category.categoryid, item.category.categoryname));
                                        CartList.Add(cust_cart);
                                        Console.WriteLine("Add To cart Is Successfull\n");
                                    }

                                }
                            }

                        }
                    }
                    Console.WriteLine("1.Revisit\t2.Display Cart And Payment");
                    num = Convert.ToInt32(Console.ReadLine());
                } while (num == 1);
            }
            foreach (Product item in CartList)
            {
                Console.WriteLine("Product id : " + item.Product_id);
                Console.WriteLine("Product Name : " + item.Product_name);
                Console.WriteLine("Product Price : " + item.Product_price);
                Console.WriteLine("Product Quantity : " + item.Product_qty);
                Console.WriteLine("Product Quantity : " + item.category.categoryid);
                Console.WriteLine("Product Quantity : " + item.category.categoryname);
                Console.WriteLine("\n");
            }
            Console.WriteLine("1.Delete cart List\t2.Order");
            num2 = Convert.ToInt32(Console.ReadLine());
            do
            {

                if (num2 == 1)
                {
                    Console.WriteLine("Enter Product Id To Delete");
                    int PI = Convert.ToInt32(Console.ReadLine());
                    foreach (Product item in CartList)
                    {
                        if (PI == item.Product_id)
                        {
                            CartList.Remove(item);
                            Console.WriteLine("Cart item " + PI + " Deleted");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Item is not in the Cart");
                            break;
                        }


                    }
                }
                else
                {
                    break;
                }

                Console.WriteLine("1.Remove Another Cart\t2.Order");
                num3 = Convert.ToInt32(Console.ReadLine());
            } while (num3 == 1);

            foreach (Product item in CartList)
            {
                Console.WriteLine("Updated Cart List");
                Console.WriteLine("Product id : " + item.Product_id);
                Console.WriteLine("Product Name : " + item.Product_name);
                Console.WriteLine("Product Price : " + item.Product_price);
                Console.WriteLine("Product Quantity : " + item.Product_quantity);
                Console.WriteLine("Product Quantity : " + item.category.categoryid);
                Console.WriteLine("Product Quantity : " + item.category.categoryname);
                Console.WriteLine("\n");
            }

            Console.WriteLine("Enter Details To Complete Order");
            Console.WriteLine("Enter First Name : ");
            OrderObj.firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name : ");
            OrderObj.lastName = Console.ReadLine();
            Console.WriteLine("Enter Mobile Number : ");
            OrderObj.mobileNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Delivery Address : ");
            OrderObj.deliveryAddress = Console.ReadLine();
            Console.WriteLine("Enter Pincode : ");
            OrderObj.pinCode = Convert.ToInt32(Console.ReadLine());

            TotalPrice = TotalPrice1 + TotalPrice2 + TotalPrice3 + TotalPrice4;

            Console.WriteLine("Enter Payment method");
            Console.WriteLine("1.ByCash\t2.ByCard");
            num4 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Order Successfully Placed..................");
            Console.WriteLine("First Name : " + OrderObj.firstName + "\nLast Name : " + OrderObj.lastName + "\nMobile Number : " + OrderObj.mobileNo + "\nDelivery Address : " + OrderObj.deliveryAddress + "\nPinCode : " + OrderObj.pinCode);
            if (num4 == 1)
            {
                GrandTotal1 = paymentObj.CalculateCGST(num4, TotalPrice);
                Console.WriteLine("Central GST is : " + GrandTotal1);
                GrandTotal2 = paymentObj.CalculateSGST(num4, TotalPrice);
                Console.WriteLine("State GST is : " + GrandTotal2);
            }
            else if (num4 == 2)
            {
                double GrandTotal3 = paymentObj.CalculateCGST(num4, TotalPrice);
                Console.WriteLine("Central GST is : " + GrandTotal3);
                double GrandTotal4 = paymentObj.CalculateSGST(num4, TotalPrice);
                Console.WriteLine("State GST is : " + GrandTotal4);
            }
            else
            {
                Console.WriteLine("Wrong Choice");
            }

            Console.WriteLine("Thank You For Visiting.....................................");

        }
    }
}

        }
    }
}
