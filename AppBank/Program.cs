using System;

namespace AppBank
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageBox.Message();
            BankService bank = new BankService();
            string InputUserNumber = Console.ReadLine();


            if (InputUserNumber == "1")
            {
                Console.Clear();
                foreach (var c in bank.Customers)
                {
                    Console.WriteLine($"{c.Id}    {c.FullName}    {c.AccountNumber}   {c.Saldo}");
                }
            }
            else if (InputUserNumber == "2")
            {
                Console.Clear();
                Console.WriteLine("Zaloguj się wybierając ID klienta");
                string klientID = Console.ReadLine();

                bool foundid = false;
                Customer variableid = null;

                foreach (var item in bank.Customers)
                {
                    if (item.Id == Convert.ToInt32(klientID))
                    {
                        Console.Clear();
                        foundid = true;
                        variableid = item;
                        break;
                    }
                }

                if (!foundid)
                {
                    MessageBox.MessageFailId();
                    return;
                }

                MessageBox.MessageTrueCustomer(variableid);

                string AccountNumberTrue = Console.ReadLine();
                bool foundaccount = false;

                Customer variableaccount = null;

                foreach (var item in bank.Customers)
                {
                    if (item.AccountNumber == AccountNumberTrue)
                    {
                        Console.Clear();
                        foundaccount = true;
                        variableaccount = item;
                        break;
                    }
                }

                if (!foundaccount)
                {
                    MessageBox.MessageFailAccount();
                    return;
                }

                MessageBox.MessageAccount();

                string CustomerValue = Console.ReadLine();

                
                if(!(BankService.TransferBalance(variableid, variableaccount, Convert.ToDecimal(CustomerValue))))
                {
                    MessageBox.InsufficentBalance();
                    return;
                }

                Console.Clear();

                foreach (var summary in bank.Customers)
                {
                    Console.WriteLine($"{summary.Id}    {summary.FullName}    {summary.AccountNumber}   {summary.Saldo}");
                }

            }
        }
    }
}

