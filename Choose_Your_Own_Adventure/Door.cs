using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Own_Adventure
{
    internal class Door
    {
        private Item key;
        private Boolean open=false;
        private int HP;
        public Door( Item a_Key,int a_HP) 
        {
            key = a_Key;
            HP = a_HP;
        }
        public Room NextRoom;
        public Room PrevRoom;
        public void OpenDoor(Player player) 
        {
            Console.WriteLine("");
            Console.WriteLine("You Found a door. Do you want to try to open it?");
            for (int i = 0; i < player.Inventory.Count; i++)
            {
                Item RightKey = player.Inventory[i];
                if (key == RightKey) 
                {
                    Console.WriteLine("You have the key");
                    open = true;
                }
            }
                Console.WriteLine("1. Try to open it");
            Console.WriteLine("2.Back to Previous Room");
            if (int.TryParse(Console.ReadLine(), out int choice) && (choice == 1 || choice == 2 ))
            {
                if (choice == 1)
                {
                        if (open)
                            NextRoom.PrintRoomDetails(player);
                        else
                        {
                            HP--;
                            Console.WriteLine("You do not have the key to open the door");
                            if (HP == 0)
                            {
                            open = true;
                            Console.WriteLine("The Door seems open");
                            }
                            this.OpenDoor(player);
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
