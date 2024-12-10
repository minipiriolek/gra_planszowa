// See https://aka.ms/new-console-template for more information
public class Player
{
    public string Name { get; set; }
    public string Position { get; set; }
    public string Score { get; set; }

    public void Ruch_na_planszy(int steps)
    {
        Position += steps;
    }

    public void Aktualizacja_punktow(int punkty)
    {
        Score += punkty;
    }
}

public class Board
{
    private int Rozmiar_planszy;

    public void Losowanie_nagrod()
    {
        Random Generowanie_nagrod = new Random();
        for (int i = 0; i < Rozmiar_planszy / 4; i++)
        {
            int pozycja = Generowanie_nagrod.Next(1, Rozmiar_planszy);
            int nagroda = Generowanie_nagrod.Next(1, 7);
        }
    }
    
}
internal class Program
{
    public static void Main(string[] args)
    {
        
    }
}