using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam_F2020_7243.Classes.State
{

    public class Normal_State : IState
    {
        private static Normal_State instance = null;
        private Normal_State() { }

        public static Normal_State GetInstance()
        {
            if (instance == null)
            {
                instance = new Normal_State();
            }
            return instance;
        }
        public void Drink_Potion(Mario mario)
        {
            mario.Heal();
            mario.State = Super_State.GetInstance();
        }

        public void Hit_Ghost(Mario mario, Ghost ghost)
        {
            int damage = RNG.Get_Instance().Next(20, 31);
            mario.LooseEnergy(damage);

        }

        public void Take_Key(Mario mario)
        {
            mario.Keys++;
        }
    }
}
