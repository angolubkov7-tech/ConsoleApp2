using System;

class Program
{
    
    enum BankAccountType
    {
        Текущий,
        Сберегательный
    }

    
    struct BankAccount
    {
        public BankAccountType Type; 
        public decimal Balance;      
    }

    static void Main(string[] args)
    {
        
        BankAccount myAccount;
        myAccount.Type = BankAccountType.Сберегательный;
        myAccount.Balance = 150500.75m; 
        Console.WriteLine($"Вид банковского счета: {myAccount.Type}");
        Console.WriteLine($"Баланс счета: {myAccount.Balance:C}");
    }
}
 // rfr tkd

        
   