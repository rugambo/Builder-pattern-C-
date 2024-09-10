using Builder_pattern_C_;

internal class Program
{
    private static void Main(string[] args)
    {
        //Create new objects of type Player, that call a defined constructor
        //Player playerObject = new Player("player_1");
        //Player enemyObject = new Player("enemy_1");

        //instanciate an instance of a new player
        PlayerBuilder playerBuilder = new PlayerBuilder();
        Player playerBuilt = playerBuilder.BuildPlayer();
       
        //Printout the name of object
        //Console.WriteLine(playerObject.CreatePlayerDescription());
        //Console.WriteLine(enemyObject.CreatePlayerDescription());

        //Printout the new instance of a player from the builder
        Console.WriteLine(playerBuilt.CreatePlayerDescription());
    }
}