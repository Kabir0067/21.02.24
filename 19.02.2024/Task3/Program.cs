var Player1 = new Player();
Console.Write("Enter player's name: ");
Player1.Name = Console.ReadLine();
Console.Write("Enter player's number: ");
Player1.Number = int.Parse(Console.ReadLine());
Console.Write("Enter player's position: ");
Player1.Position = Console.ReadLine();
Console.Write("Enter player's team: ");
Player1.Team = Console.ReadLine();
Player1.ScoreGoal();
Player Neymar = new Player();
Neymar.Name = "Neymar";
Player1.AssistGoal(Neymar);
Console.WriteLine(Player1.GetInfo());
public class Player
{
    public string Name;
    public int Number;
    public string Position;
    public string Team;


    public void ScoreGoal()
    {
        Console.WriteLine($"Player {Name} scores a goal.");
    }


    public void AssistGoal(Player Neymar)
    {
        Console.WriteLine($"Player {Name} assists a goal for player {Neymar.Name}.");
    }


    public string GetInfo()
    {
        return $"Name: {Name}\nNumber: {Number}\nPosition: {Position}\nTeam: {Team}";
    }

}