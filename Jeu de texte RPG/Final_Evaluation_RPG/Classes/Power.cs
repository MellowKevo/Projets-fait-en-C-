using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Final_Evaluation_RPG.Classes
{
    public enum PowerType { Healing, Invisible, Protect, Sleepy }

    public class Power : Item
    {
       private PowerType type;
       private int minXp;

      public Power()
        {

        }

        public Power(string name, int price, PowerType type, int minXp) : base(name, price)
        {
            this.Type = type;
            this.MinXp = minXp;
           
        }

        public PowerType Type { get => type; set => type = value; }
        public int MinXp { get => minXp; set => minXp = value; }
    }
}
