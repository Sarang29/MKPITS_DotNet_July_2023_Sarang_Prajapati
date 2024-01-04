using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi_Product_Form_Insert_Update_Delete
{
    internal class Product
    {
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public Product(int prodId, string prodName, int price, int quantity)
        {
            ProdId = prodId;
            ProdName = prodName;
            Price = price;
            Quantity = quantity;
        }
    }
}
