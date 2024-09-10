using Builder_pattern_C_;

internal class Program
{
    private static void Main(string[] args)
    {
        Player playerObject = new Player("player_1");
        Player enemyObject = new Player("enemy_1");
        //Console.WriteLine("Hello, World!");
        Console.WriteLine(playerObject.CreatePlayerDescription());
        Console.WriteLine(enemyObject.CreatePlayerDescription());
    }
}