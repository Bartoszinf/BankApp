using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBank
{
    public class BankService
    {
        public BankService()
        {
            Customers.Add(new Customer(1, "Jan Nowak", "001", 1457.23m));
            Customers.Add(new Customer(2, "Agnieszka Kowalska", "002", 3600.18m));
            Customers.Add(new Customer(3, "Robert Lewandowski", "003", 2745.03m));
            Customers.Add(new Customer(4, "Zofia Plucińska", "004", 7344.00m));
            Customers.Add(new Customer(5, "Grzegorz Brown", "005", 455.38m));
        }

        public List<Customer> Customers { get; set; } = new List<Customer>();
        public static bool TransferBalance(Customer from, Customer to, decimal amount)
        {
            if (from.Saldo < amount) return false;
            to.Saldo += amount;
            from.Saldo -= amount;
            return true;
        }
    }
}
