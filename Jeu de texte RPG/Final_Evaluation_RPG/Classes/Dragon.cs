using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Evaluation_RPG.Classes
{
    public class Dragon : Monster
    {
        private int rgp;

      
        public Dragon()
        {

        }
        public Dragon(string name, int hp, int ap, int rxp) : base(name, hp, ap, rxp)
        {
            this.Rgp = rgp;
            Random rpg = new Random();
            rpg.Next(1000, 10000);
           
        }

        public int Rgp { get => rgp; set => rgp = value; }
    }
}
