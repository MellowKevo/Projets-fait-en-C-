using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam_F2020_7243.Classes.State
{
    public interface IState
    {
        void Drink_Potion(Mario mario);
        void Take_Key(Mario mario);

        void Hit_Ghost(Mario mario, Ghost ghost);
    }
}
