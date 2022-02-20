using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBank
{
    public class Customer
    {

        public Customer(int id, string fullName, string accountNumber, decimal saldo)
        {
            Id = id;
            FullName = fullName;
            AccountNumber = accountNumber;
            Saldo = saldo;

        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string AccountNumber { get; set; }
        public decimal Saldo { get; set; }

    }
}
