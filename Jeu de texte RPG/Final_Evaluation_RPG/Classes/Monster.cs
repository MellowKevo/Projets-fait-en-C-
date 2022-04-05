using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Evaluation_RPG.Classes
{
    public class Monster : LivingEntity
    {
        private int ap;
       private int rxp;
        Player target;

        public Monster()
        {

        }
        public Monster(string name, int hp, int ap, int rxp) : base(name, hp)
        {
            this.Ap = ap;
            this.Rxp = rxp;
            this.Target = target;
        }

      
        public int Ap { get => ap; set => ap = value; }
        public int Rxp { get => rxp; set => rxp = value; }
        public Player Target { get => target; set => target = value; }

        public override void Attack()
        { 
            int random = Dice.GetInstance().Next(0, ap);
            Console.WriteLine("\n The enemy " + this.Name + " is attacking now..");
            Target.ReceiveDamage(random);
           
            
        }
        
        
        
    }
}
