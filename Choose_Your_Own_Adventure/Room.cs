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

        public Room(string description, Enemy enemy , Item loot)
        {
            this.Description = description;
            this.Enemy = enemy;
            this.Loot = loot;
        }
        public Room Nextroom=null;

        public void PrintRoomDetails(Player player)
        {
            Console.WriteLine($"You enter a room: {Description}");

            if (Enemy != null)
            {
                Console.WriteLine($"An enemy is in the room: {Enemy.s_Name}");
            }

            if (Loot != null)
            {
                Console.WriteLine($"You find loot in the room: {Loot.Name}");
            }
            this.EnterRoom(player);
        }

        public void ChooseAction(Player player)
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Find Loot in the room");
            Console.WriteLine("2. Fight an enemy");
            Console.WriteLine("3. Back to previous chioce");
            Console.Write("Enter your choice (1 or 2): ");

            if (int.TryParse(Console.ReadLine(), out int choice) && (choice == 1 || choice == 2 || choice == 3))
            {
                if (choice == 1) 
                {
                    if (Loot != null) 
                    {
                        player.AddItemToInventory(Loot);
                    }
                    else 
                    { 
                        Console.WriteLine("There is no Loot in the room"); 
                    }
                }
                else if (choice == 2) 
                {
                    player.fight(Enemy);
                    this.ChooseAction(player);
                }
                else if(choice == 3) 
                {
                    this.EnterRoom(player);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 1 or 2.");
                this.ChooseAction(player);
            }
        }
        public void EnterRoom(Player player)
        {
            Console.WriteLine("You find a room you can enter. Choose an action:");
            Console.WriteLine("1. Progress to the next room");
            Console.WriteLine("2. Enter this room");
            Console.Write("Enter your choice (1 or 2): ");

            if (int.TryParse(Console.ReadLine(), out int choice) && (choice == 1 || choice == 2))
            {
                if (choice == 1)
                {
                    if (Nextroom != null)
                    {
                        Nextroom.PrintRoomDetails(player);
                    }
                    else
                    {
                        Console.WriteLine("There is no Next room");
                    }
                }
                else if (choice == 2)
                {
                    this.ChooseAction(player);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 1 or 2.");
                this.EnterRoom(player);
            }
        }

    }
}
