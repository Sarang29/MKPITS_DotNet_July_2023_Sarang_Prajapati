using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Class_Product_Constructor_With_or_Without_Para
{
    class Product
    {
        int ProductId;
        string ProductName;
        int Price;
        int Quantity;

        public Product()
        {
            ProductId = 1;
            ProductName = "KitKat";
            Price = 50;
            Quantity = 600;
        }

        public Product(int ProductId,string ProductName,int Price,int Quantity)
        {
            this.ProductId = ProductId;
            this.ProductName = ProductName;
            this.Price = Price;
            this.Quantity = Quantity;
        }

        public void display()
        {
            Console.WriteLine("Product Id : " + ProductId);
            Console.WriteLine("Product Name : " + ProductName);
            Console.WriteLine("Product Price : " + Price);
            Console.WriteLine("Product Quantity : " + Quantity);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.display();

            Console.WriteLine();

            Console.Write("Enter Product Id : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Product Name : ");
            string name = Console.ReadLine();

            Console.Write("Enter Product Price : ");
            int price = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Product Quantity : ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Product product2 = new Product(id,name,price,quantity);
            product2.display();

            Console.ReadKey();
        }
    }
}
