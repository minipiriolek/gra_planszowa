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
internal class Program
{
    public static void Main(string[] args)
    {
        
    }
}