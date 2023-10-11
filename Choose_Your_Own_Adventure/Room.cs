using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Own_Adventure
{
    internal class Room
    {
        private string Description;
        private Enemy Enemy;
        private Item Loot;
        private Character Character;
        private int id = 1;
        private static int count = 1;

        public Room(string description, Enemy enemy , Item loot)
        {
            this.Description = description;
            this.Enemy = enemy;
            this.Loot = loot;
            id = count;
            count++;
        }
        public Room Nextroom = null;
        public Room Prevroom = null;
        public Door NextDoor = null;
        public Room(string description, Character character, Item loot)
        {
            this.Description = description;
            this.Character = character;
            this.Loot = loot;
        }
        public void PrintRoomDetails(Player player)
        {
            Console.WriteLine("");
            Console.WriteLine($"You enter a room: "+Description);

            if (Enemy != null)
            {
                Console.WriteLine($"An enemy is in the room: "+Enemy.GetName);
            }
            this.EnterRoom(player);
        }

        public void ChooseAction(Player player)
        {
            Console.WriteLine("");
            Console.WriteLine("You enter Room"+id);
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Find Loot in the room");
            Console.WriteLine("2. Fight ");
            if (Enemy != null) 
            {
                Enemy.printinfo();
            }
            if (Character != null)
            { 
                Character.printinfo();
            }
            Console.WriteLine("3. Back to previous chioce");
            Console.Write("Enter your choice (1 or 2 or 3): ");

            if (int.TryParse(Console.ReadLine(), out int choice) && (choice == 1 || choice == 2 || choice == 3))
            {
                if (choice == 1) 
                {
                    if (Loot != null) 
                    {
                        player.AddItemToInventory(Loot);
                        Loot = null;
                        this.ChooseAction(player);
                    }
                    else 
                    { 
                        Console.WriteLine("There is no Loot in the room");
                        this.ChooseAction(player);
                    }
                }
                else if (choice == 2) 
                {
                    if (Enemy != null)
                    {
                        player.fight(Enemy);
                        player.printinfo();
                        Enemy = null;
                        this.ChooseAction(player);
                    }
                    else if (Character != null)
                    {
                        player.fight(Character);
                        player.printinfo();
                        Character = null;
                        this.ChooseAction(player);
                    }
                    else
                    {
                        Console.WriteLine("There is no one Here");
                        this.ChooseAction(player);
                    }
                }
                else if(choice == 3) 
                {
                    this.EnterRoom(player);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 1 or 2 or 3.");
                this.ChooseAction(player);
            }
        }
        public void EnterRoom(Player player)
        {
            Console.WriteLine("You find a room you can enter. Choose an action:");
            Console.WriteLine("1. Progress to the next room");
            Console.WriteLine("2. Enter this room");
            Console.WriteLine("3. Back to the previous room");
            Console.Write("Enter your choice (1 or 2 or 3): ");

            if (int.TryParse(Console.ReadLine(), out int choice) && (choice == 1 || choice == 2 || choice == 3))
            {
                if (choice == 1)
                {
                    if (Nextroom != null)
                    {
                        if (NextDoor != null) 
                        {
                            NextDoor.OpenDoor(player);
                        }
                        else
                        {
                            Nextroom.PrintRoomDetails(player);
                        } 
                    }
                    else
                    {
                        Console.WriteLine("There is no Next room");
                        Console.WriteLine("This is the end of the Demo");
                        player.printinfo();
                        player.DisplayInventory();
                    }
                }
                else if (choice == 2)
                {
                    this.ChooseAction(player);
                }
                else if (choice == 3)
                {
                    if (Prevroom != null)
                    {
                        Prevroom.PrintRoomDetails(player);
                    }
                    else
                    {
                        Console.WriteLine("There is no previous room");
                        this.PrintRoomDetails(player);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 1 or 2 or 3.");
                this.EnterRoom(player);
            }
        }
    }
}
