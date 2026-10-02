using System;
using System.Xml.Linq;

class Program
{
    enum BankAccountType
    {
        Текущий,
        Сберегательный
    }

    struct BankAccount
    {
        public string Number;
        public BankAccountType Type;
        public decimal Balance;
    }
    static void Main(string[] args)
    {
        BankAccount num = new BankAccount();
        num.Type = BankAccountType.Сберегательный;
        num.Balance = 150000.75m;
        num.Number = "2345676543213456765432";
        Console.WriteLine($"Номер банковского счета: {num.Number}");
        Console.WriteLine($"Вид банковского счета: {num.Type}");
        Console.WriteLine($"Баланс банковского счета: {num.Balance}");

        Console.WriteLine();

        BankAccount current = new BankAccount();
        current.Type = BankAccountType.Текущий;
        current.Balance = 1208m;
        current.Number = "31456789423746243";
        Console.WriteLine($"Номер банковского счета: {current.Number}");
        Console.WriteLine($"Вид банковского счета: {current.Type}");
        Console.WriteLine($"Баланс банковского счета: {current.Balance}");
    }
} 