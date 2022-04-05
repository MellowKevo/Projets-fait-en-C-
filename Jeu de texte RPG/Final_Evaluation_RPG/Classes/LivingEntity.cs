using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Evaluation_RPG.Classes
{
    public abstract class LivingEntity : ILivingEntity
    {
        private string name;
        private int hp;

        public LivingEntity(string name, int hp)
        {
            this.Name = name;
            this.Hp = hp;
        }
        public LivingEntity()
        {

        }

        
        public string Name { get => name; set => name = value; }
        public int Hp { get => hp; set => hp = value; }

        public bool IsDead()
        {
            if (this.Hp <= 0)
            {
                return true;
            }
           else return false;
        }

        public virtual void ReceiveDamage(int damage)
        {
            this.Hp -= damage;
            Console.Write("The enemy is hit ! His current hp is now: " + this.Hp);
        }
        public abstract void Attack();
    }
}
