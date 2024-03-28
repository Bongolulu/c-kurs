namespace Classes;

public class finance
    {
        static void Main()
        {
            class Stock
            {
        public string Symbol { get; }
        public string Name { get;}
        public string Anzahl { get; }
        public decimal Price { get; }
        private decimal Cash { get;}
        private string User_id { get;}
        private string id { get;}
        

        public Shares(string symbol, string name, string anzahl, decimal price)
        {
            Symbol = symbol;
            Name = name;
            Anzahl = anzahl;
            Price = price;
        }
    }

    class Buy
    {
        public Symbol { get; }
        public int Anzahl { get; }
        public decimal Kaufkosten { get { return Share.Price * Anzahl; } }

        public Kaufkosten (int share, int anzahl)
        {
            Share = share;
            Anzahl = anzahl;
        }
    }
 