using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBank
{
    static class MessageBox
    {
        public static void Message()
        {
            Console.WriteLine("Witaj w aplikacji banku.");
            Console.WriteLine("WYBIERZ OPCJE: ");
            Console.WriteLine("1 => LISTA WSZYSTKICH KLIENTÓW");
            Console.WriteLine("2 => LOGOWANIE");
            Console.WriteLine("3 => ZAKOŃCZ PROGRAM");
            Console.WriteLine("PROSZĘ WYBRAĆ OPCJE 1,2 LUB 3: ");
        }

        public static void MessageFailId()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Logowanie nieudane");
            Console.ResetColor();
        }
        public static void MessageTrueCustomer(Customer veriableid)
        {
            Console.Clear();
            Console.WriteLine("ZALOGOWANY KLIENT");

            Console.WriteLine($"ID: {veriableid.Id}");
            Console.WriteLine($"Imie i nazwisko: {veriableid.FullName}");
            Console.WriteLine($"Numer konta: {veriableid.AccountNumber}");
            Console.WriteLine($"Dostępne środki: {veriableid.Saldo}");

            Console.WriteLine("WPISZ NUMER KONTA NA KTÓRY CHCESZ WYKONAĆ PRZELEW: ");
        }
        public static void MessageFailAccount()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("NIEPRAWIDŁOWY NUMER KONTA");
            Console.ResetColor();
        }

        public static void MessageAccount()
        {
            Console.Clear();
            Console.WriteLine("PROSZĘ PODAĆ KWOTĘ PRZELEWU: ");
        }

        public static void InsufficentBalance()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("NIEWYSTARCZAJĄCE ŚRODKI NA RACHUNKU");
            Console.ResetColor();
            
        }
    }
}
