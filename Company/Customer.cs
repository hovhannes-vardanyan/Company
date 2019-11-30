using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Customer : IPerson
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Amount { get; protected set; }

        public void Order(Product order)
        {
            this.Amount += order.Price;
        }
        public Customer(int id, string name, string lastname,Product order)
        {
            this.ID = id;
            this.FirstName = name;
            this.LastName = lastname;
            this.Amount = order.Price;
        }

    }
}
