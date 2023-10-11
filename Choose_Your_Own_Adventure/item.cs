using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Own_Adventure
{
    internal class Item
    {
            private string name;
            private int attackValue;
            private int defenseValue;

            public Item(string name, int attackValue, int defenseValue)
            {
                this.name = name;
                this.attackValue = attackValue;
                this.defenseValue = defenseValue;
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int AttackValue
            {
                get { return attackValue; }
                set { attackValue = value; }
            }

            public int DefenseValue
            {
                get { return defenseValue; }
                set { defenseValue = value; }
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Item Name: {Name}");
                Console.WriteLine($"Attack Value: {AttackValue}");
                Console.WriteLine($"Defense Value: {DefenseValue}");
            }
        }
    }
