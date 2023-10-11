using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Own_Adventure
{
    internal class Door
    {
        private int HP;
        private Item key;
        public Door(int a_HP, Item a_Key) 
        {
            HP = a_HP;
            key = a_Key;
        }
        public Room NextRoom;
        public Room PrevRoom;
        public void OpenDoor(Player player) 
        {
            Console.WriteLine("You Found a door. Do you want to try to open it?");
            Console.WriteLine("1. Try to open it");
            Console.WriteLine("2.Back to Previous Room");
            if (int.TryParse(Console.ReadLine(), out int choice) && (choice == 1 || choice == 2 ))
            {
                if (choice == 1)
                {
                    for (int i = 0; i < player.Inventory.Count; i++)
                    {
                        Item RightKey = player.Inventory[i];
                        if (key == RightKey)
                            NextRoom.PrintRoomDetails(player);
                        else
                        {
                            Console.WriteLine("You do not have the key to open the door");
                            this.OpenDoor(player);
                        }
                    }
                }
                if(choice == 2) 
                { 
                    PrevRoom.PrintRoomDetails(player);
                }
                else 
                    {
                    Console.WriteLine("Invalid Input");
                    this.OpenDoor(player);
                    }
            }
        }
    }
}
