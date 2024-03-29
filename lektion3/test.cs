using System.Diagnostics.SymbolStore;
using System.Net.Http;
using System.Threading.Tasks;

namespace Classes;

public class finance
{
    public string Symbol { get; }
    public string Name { get; }
    public string Anzahl { get; }
    public decimal Price { get; }
    private decimal Cash { get; }
    private string User_id { get; set; }

    public void Buy(decimal shares, decimal price)
    {
    }

    public void Sell(decimal shares, decimal price)
    {
    }

// Konstruktor


    public finance(string name, decimal initialBalance) //initialBalance = erste Buchung 10.000. Falsch hier
    {
        Symbol = symbol;
        Shares = shares;
        Price = price;
        
    }
    
    
    // User_id erhöhen
    public user_id (string name)
    {
        User = name;
        MakeDeposit(initialBalance, DateTime.Now, "10.000");
        Number = s_user_id.ToString();
        user_id++;
    }


public class 
    (string symbol, string name, string anzahl, decimal price)
        {
            Symbol = symbol;
            Name = name;
            Anzahl = anzahl;
            Price = price;
        }
    }

    public class Buy
    {
        public Symbol { get; }
        public int Anzahl { get; }
        public decimal Kaufkosten { get { return Share.Price * Anzahl; } }

        public Kaufkosten (int share, int price)
        {
            Share = share;
            Price = price;
        }
    }

    public class Sell
    {
        public Symbol { get; }
        public int Anzahl { get; }

        public decimal Verkaufspreis
        {
            get { return -Share.Price * Anzahl; }
        }

        public Verkaufspreis(int share, int price)
        {
            Share = share;
            Price = price;
        }
        
        // Zahl zwischen 0 und 9 eingeben:

        int userInput;
            do
        {
            if (!int.TryParse(Console.ReadLine(), out userInput) || userInput < 0 || userInput > 9)
            {
                Console.WriteLine("Please enter an integer larger than 0");
            }
        } while (userInput < 0 || userInput > 9);
        