using Classes;
class Program
{
    static void Main2()
    {
        var account = new finance("xxx", "xxx");
        
        account.MakeDeposit(50,DateTime.Today, "Taschengeld");  //Buy
        account.MakeWithdrawal(500, DateTime.Now, "Rent payment"); //Sell
        account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
        account.MakeDeposit(5000000, DateTime.Now, "Lottogewinn");
        
        // Anforderung des Kunden: Kontoauszug drucken

        Console.WriteLine(account.GetAccountHistory());









    }   
}