class Schulkalender // Klasse erstellt
{   // Attribute deklarieren (mit int)
    private int SchulbeginnMonat;
    private int SchulbeginnTag;
    private int Mindestalter;
    // Contruktur (gleicher Name wie Klasse) und dann die drei Werte initialisieren (ohne int). Public machen.
    public Schulkalender(int sm, int st, int ma)
    {
        SchulbeginnMonat = sm;
        SchulbeginnTag = st;
        Mindestalter = ma;
    }
    // Verhalten der Klasse, also warum ich die überhaupt erstellt habe. Hier soll sie was tun mit Methoden:
    // 1. Methode (vorher Funktion): Einschulungsdatum, basierend auf einem Geburtsdatum berechnen.
    public int Einschulungsdatum (int geburtsdatum)
    {
        int einschulungsjahr = geburtsdatum / 10000 + Mindestalter;
        
        // Beispiel: wir haben 1982 und wollen haben 19820801
        int einschulungstag = einschulungsjahr *10000+ SchulbeginnMonat *100 + SchulbeginnTag;
        // wenn geburtsTagMonat > einschulungsTagMonat dann +1 Jahr
        int geburtsTagMonat = geburtsdatum % 10000;
        int einschulungsTagMonat = einschulungstag % 10000;
        if (geburtsTagMonat > einschulungsTagMonat)
        {   // hier + 10000 damit wir plus ein jahr haben wenn wir nach dem einschulugstag geburtstag haben
            einschulungstag += 10000;
        }
        return einschulungstag;
    }
    // 2. Methode: Wann feiert der Schüler zum ersten Mal seinen Geburtstag in der Schule?
    public int Schulgeburtstag(int geburtsdatum)
    {
        int einschulungsdatum = Einschulungsdatum(geburtsdatum); 
        int einschulungsTagMonat = einschulungsdatum % 10000;
        int feierjahr = einschulungsdatum / 10000;
        
        int geburtsTagMonat = geburtsdatum % 10000;

         if (geburtsTagMonat < einschulungsTagMonat)
         {
             feierjahr += 1;
         }

         return feierjahr * 10000 + geburtsTagMonat;
    }
    
}






// hier fängt das Programm an
class Program
{
    public static void Main()
    {
        //Deklaration der Variable "meinKalender" mit dem Datentyp "Schulkalender"
        // Zuweisung eines neuen Schulkalenders zur Variable meinKalender
        Schulkalender meinKalender = new Schulkalender(8, 1, 5);
        Schulkalender meinAndererKalender = new Schulkalender(9, 1, 5);
        int meinEinschulungsDatum = meinKalender.Einschulungsdatum(19770513);
        int meinAnderesEinschulungsDatum = meinAndererKalender.Einschulungsdatum(19770513);

        int meinErsterSchulgeburtstag = meinKalender.Schulgeburtstag(19770513);
        int meinAndererErsterSchulgeburtstag = meinAndererKalender.Schulgeburtstag(19770513);
        
        Console.WriteLine(meinEinschulungsDatum);
        Console.WriteLine(meinAnderesEinschulungsDatum);
        Console.WriteLine(meinErsterSchulgeburtstag);
        Console.WriteLine(meinAndererErsterSchulgeburtstag);
    }
}