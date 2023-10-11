using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace Choose_Your_Own_Adventure
{
    internal class Player : Character
    {
        public List<Item> Inventory;

        public Player(string name, int attack, int defense)
            : base(name, attack, defense)
        {
            Inventory = new List<Item>();
        }
        public int getHP()
        {
            return i_HP;
        }
        public string getName()
        {
            return s_Name;
        }
        public int getAttack()
        {
            return i_Attack;
        }
        public int getDef()
        {
            return i_Defense;
        }
        public void AddItemToInventory(Item item)
        {
            Inventory.Add(item);
            Console.WriteLine($"you found and added {item.Name} to their inventory.");
            i_Attack += item.AttackValue;
            Console.WriteLine($"your attack value is now {i_Attack}.");
            i_Defense += item.DefenseValue;
            Console.WriteLine($"your defense value is now {i_Defense}.");
        }

        public void DisplayInventory()
        {
            Console.WriteLine($"Inventory:");
            foreach (Item item in Inventory)
            {
                Console.WriteLine($"{item.Name}");
            }
        }
        public void fight(Enemy enemy)
        {
            if (enemy.HP <= 0)
            {
                enemy.DefeatEnemy(this);
            }
            else
            {
                int damage = this.i_Attack - enemy.getDef();
                if (damage > 0) 
                {
                    enemy.TakeDamage(damage);
                    Console.WriteLine(this.s_Name+" attacks "+enemy.s_Name+ " for "+damage+" damage!");
                    enemy.fight(this);
                }
            }
        }
        public void fight(Character character)
        {
            if (character.HP <= 0)
            {
                Console.WriteLine("You kill a innocent character");
            }
            else
            {
                int damage = this.i_Attack - character.GetDefense;
                if (damage > 0)
                {
                    character.TakeDamage(damage);
                    Console.WriteLine(this.s_Name + " attacks " + character.s_Name + " for " + damage + " damage!");
                    this.fight(character);
                }
            }
        }
        public override void printinfo()
        {
            Console.WriteLine("Player Name: " + s_Name);
            Console.WriteLine("Player HP: " + i_HP);
            Console.WriteLine("Player ATK: " + i_Attack);
            Console.WriteLine("Player DEF: " + i_Defense);
        }
    }
}
