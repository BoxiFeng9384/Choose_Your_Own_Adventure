namespace Choose_Your_Own_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item loot1 = new Item("TEST ENEMY's SOUL ", 1, 1,20);
            Item loot2 = new Item("Rusty Sword", 5, 1, 0);
            Item loot3 = new Item("Tattered Clothes", 0, 3, 10);
            Item loot4 = new Item("Rubber Rod", 10, 2,0);
            Item loot5 = new Item("Laboratory key", 0, 0, 0);
            Door door1 = new Door(loot5,10);
           
            Player player = new Player("SUBJECT 7001",120,12,2);
            
            Enemy enemy1 = new Enemy("TEST ENEMY 7002",30 ,12, 2,loot1);
            Enemy enemy2 = new Enemy("TEST ENEMY 7003", 30, 12, 2, loot1);
            Enemy enemy3 = new Enemy("TEST ENEMY 7006", 30, 12, 2, loot1);
            Enemy enemy4 = new Enemy("TEST ENEMY 7007", 30, 12, 2, loot1);
            Enemy enemy6 = new Enemy("TEST ENEMY 7777 Ver1.0", 100, 20, 16, loot1);
            
            Character Character1 = new Character("SUBJECT 7004",1, 1, 1);
            Character Character2 = new Character("SUBJECT 7005", 1,1, 1);
            Character Character3 = new Character("SUBJECT 7008", 1,1, 1);

            Room Room5 = new Room("All around you are dilapidated stone walls and earthbags, with only the door to the next room still flickering faintly. \nYou can see what appears to be a figure in the room by the light. \nYou notice that something seems to be glowing in the earthbag.", Character1, loot4);
            Room Room1 = new Room("All around them were dilapidated stone walls and earthbags, with only the door to the next room glimmering faintly.");
            Room Room2 = new Room("All around them were dilapidated stone walls and earthbags, with only the door to the next room glimmering faintly. \nYou can see by the light what appears to be figures in the room.", enemy1);
            Room Room3 = new Room("All around you are dilapidated stone walls and earthbags, with only the door to the next room still flickering faintly. \nYou can see what appears to be a figure in the room by the light. \nYou notice that something seems to be glowing in the earthbag.", enemy2, loot2);
            Room Room4 = new Room("All around you are dilapidated stone walls and earthbags, with only the door to the next room still flickering faintly. \nYou can see what appears to be a figure in the room by the light. \nYou notice that something seems to be glowing in the earthbag.", enemy3, loot3);
            Room Room6 = new Room("All around you are dilapidated stone walls and earthbags, with only the door to the next room still flickering faintly. \nYou notice that something seems to be glowing in the earthbag.", loot5);
            Room Room7 = new Room("All around them were dilapidated stone walls and earthbags, with only the door to the next room glimmering faintly. \nYou can see by the light what appears to be figures in the room.", enemy4);
            Room Room8 = new Room("All around you are dilapidated stone walls and earthbags, with only the door to the next room still flickering faintly. \nYou can see what appears to be a figure in the room by the light. \nYou notice that something seems to be glowing in the earthbag.", Character2, loot2);
            Room Room9 = new Room("All around you are dilapidated stone walls and earthbags, with only the door to the next room still flickering faintly. \nYou can see what appears to be a figure in the room by the light. \nYou notice that something seems to be glowing in the earthbag.", Character2,loot3);
            Room Room10 = new Room("It was a very dimly lit room. In the middle of the room there is a man STARING at you.", enemy6);
            Room5.Nextroom = Room1;
            Room1.Nextroom = Room2;
            Room2.Nextroom = Room3;
            Room3.Nextroom = Room4;
            Room4.Nextroom = Room6;
            Room6.Nextroom = Room7;
            Room7.Nextroom = Room8;
            Room8.Nextroom = Room9;
            Room9.Nextroom = Room10;

            Room9.NextDoor = door1;

            door1.NextRoom = Room10;
            door1.PrevRoom = Room9;



            Room1.Prevroom = Room5;
            Room2.Prevroom = Room1;
            Room3.Prevroom = Room2;
            Room4.Prevroom = Room3;
            Room6.Prevroom = Room4;
            Room7.Prevroom = Room6;
            Room8.Prevroom = Room7;
            Room9.Prevroom = Room8;

            player.printinfo();
            Room1.PrintRoomDetails(player);

        }
    }
}