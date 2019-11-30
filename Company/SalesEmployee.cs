using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    struct Product
    {
        public int Price { get; private set; }        
        public string ProductName { get; private set; }
        public int Date { get; private set; }


        public Product(int price, string productName, int date)
        {
            this.Price = price;
            this.ProductName = productName;
            this.Date = date;
        }
    }

    class SalesEmployee : Employee
    {        
        public List<Product> Sales { get; set ; }
        public SalesEmployee(int id, string name, string lastname, int salary, Departament dep, List<Product> sales)
            : base(id, name, lastname, salary, dep)
        {
            this.Sales = sales;
        }
        // veradrcnum e Producti tvyalnery stringi tesqov
        public string GetProducts()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("His/Her Products\n");
            foreach (Product product in Sales)
            {
                sb.Append($"{product.ProductName},{product.Price},{product.Date}\n");
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return "SalesEmployee " + base.ToString() + GetProducts();
        }
    }
}
