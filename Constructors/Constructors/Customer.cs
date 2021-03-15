using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Customer
    {
        //class field
        public int Id;
        public string Name;
        public List<Order> customerOrders;

        //constractor overloading
        
        public Customer() //constructor with no parameter
        {
            customerOrders = new List<Order>();
        }

        public Customer(int customerId) //constructor with single parameter
            : this()
        {
            this.Id = customerId;
        }

        public Customer(int customerId, string customerName) //constructor with multiple parameter
            : this(customerId)
            {
                this.Name = customerName;
            }
    }
}
