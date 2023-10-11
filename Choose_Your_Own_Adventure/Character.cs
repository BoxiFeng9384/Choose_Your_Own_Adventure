using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Own_Adventure
{
    internal class Character
    {
        public String s_Name;
        protected int i_HP=100;
        protected int i_Attack=10;
        protected int i_Defense=5;

        public Character(String a_sCharName) 
        { 
            s_Name=a_sCharName;
        }
        public Character(String a_sCharName,int a_iCharAttack,int a_iCharDefense)
        {
            s_Name = a_sCharName;
            i_HP=a_iCharAttack;
            i_Defense = a_iCharDefense;
        }
        public int HP 
        {
            get 
                { 
                    return i_HP; 
                }
        }
        public int GetAttack
        { 
                get 
                    { 
                        return i_Attack; 
                    } 
        }

        public void TakeDamage(int damage) 
        {
            i_HP -= damage;
        }

        public virtual void printinfo() 
        {
            Console.WriteLine("Name: " + s_Name);
            Console.WriteLine("HP: "+ i_HP);
            Console.WriteLine("ATK: " + i_Attack);
            Console.WriteLine("DEF: "+ i_Defense);
        }

        


    }
}
