﻿using Classes;
class Program
{
    static void Main()
    {
        var account = new BankAccount("Nele", 1000);
        
        account.MakeDeposit(50,DateTime.Today, "Taschengeld");
        account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
        account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
        account.MakeDeposit(5000000, DateTime.Now, "Lottogewinn");
        
        // Anforderung des Kunden: Kontoauszug drucken

        Console.WriteLine(account.GetAccountHistory());









    }   
}


