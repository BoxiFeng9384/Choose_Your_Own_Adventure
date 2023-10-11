using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Choose_Your_Own_Adventure
{
    internal class Enemy:Character
    {
        private Item loot;
        private string Name;

        public Enemy(string name, int hp,int attack, int defense, Item loot)
            : base(name,hp, attack, defense)
        {
            Loot = loot;
            Name = name;
        }

        public Item Loot
        {
            get { return loot; }
            private set { loot = value; }
        }
        public int getHP() 
        {
            return i_HP;
        }
        public string getName()
        {
            return Name;
        }
        public int getAttack() 
        {
            return i_Attack;
        }
        public int getDef() 
        {
            return i_Defense;
        }
        public void fight(Player player)
        {
                int damage = this.i_Attack - player.getDef();
            if (damage > 0)
            {
                player.TakeDamage(damage);
                Console.WriteLine(this.GetName + " attacks " + player.GetName + " for " + damage + " damage!");
                player.fight(this);
            }
            else 
            {
                Console.WriteLine(this.GetName + " attacks seems not hurt at all");
                player.fight(this);
            }
        }
        public void DefeatEnemy(Player player)
        {
            Console.WriteLine(Name+" has been defeated!");
            Console.WriteLine(Name+" drops "+Loot.Name+" as loot.");
            player.AddItemToInventory(loot);
        }
        public override void printinfo()
        {
            Console.WriteLine("Enemy Name: " + GetName);
            Console.WriteLine("Enemy HP: " + i_HP);
            Console.WriteLine("Enemy ATK: " + i_Attack);
            Console.WriteLine("Enemy DEF: " + i_Defense);
        }
    }
}
