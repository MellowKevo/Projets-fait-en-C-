using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Evaluation_RPG.Classes
{
    public class Weapon : Item
    {
        private int minDamage;
        private int maxDamage;

        
        public Weapon()
        {

        }
        public Weapon(string name, int price, int minDamage, int maxDamage) : base(name, price)
        {
            this.MinDamage = minDamage;
            this.MaxDamage = maxDamage;
        }

        public int MinDamage { get => minDamage; set => minDamage = value; }
        public int MaxDamage { get => maxDamage; set => maxDamage = value; }
    }
}
