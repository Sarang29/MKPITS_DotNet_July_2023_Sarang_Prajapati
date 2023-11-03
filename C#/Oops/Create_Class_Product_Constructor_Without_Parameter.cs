using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Class_Product_Constructor_Without_Parameter
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public Product()
        {
            ProductId = 1;
            ProductName = "Iphone";
            Price = 60000;
            Quantity = 10;
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
            Product product = new Product();

            product.display();

            Console.ReadKey();
        }
    }
}
