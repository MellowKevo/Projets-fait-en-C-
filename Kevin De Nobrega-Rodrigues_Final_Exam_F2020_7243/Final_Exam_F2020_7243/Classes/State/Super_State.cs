using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam_F2020_7243.Classes.State
{
    public class Super_State : IState
    {
        private static Super_State instance = null;
        private Super_State() { }

        public static Super_State GetInstance()
        {
            if (instance == null)
            {
                instance = new Super_State();
            }
            return instance;
        }
        public void Drink_Potion(Mario mario)
        {
            mario.Heal();
        }

        public void Hit_Ghost(Mario mario, Ghost ghost)
        {
            mario.State = Normal_State.GetInstance();
        }

        public void Take_Key(Mario mario)
        {
            mario.Keys += 2;
        }
    }
}
