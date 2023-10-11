namespace Choose_Your_Own_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item loot1 = new Item("item1", 1, 1);
            Item loot2 = new Item("item1", 1, 1);
            Item loot3 = new Item("item1", 1, 1);
            Item loot4 = new Item("item1", 1, 1);
            Item loot5 = new Item("item1", 1, 1);
            Player player = new Player("Player",10,5);
            Enemy enemy1 = new Enemy("Enemy1", 1, 1,loot1);
            Enemy enemy2 = new Enemy("Enemy1", 1, 1, loot3);
            Room Room1 = new Room("Here is Room1", enemy1, loot2);
            Room Room2 = new Room("Here is Room2", enemy1, loot3);
            Room Room3 = new Room("Here is Room3", enemy1, loot3);
            Room1.Nextroom = Room2;
            Room2.Nextroom = Room3;
            Room2.Prevroom = Room1;
            Room3.Prevroom = Room2;
            Room1.PrintRoomDetails(player);

        }
    }
}