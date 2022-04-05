using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Evaluation_RPG.Classes
{
    public interface ILivingEntity
    {
        bool IsDead();
        void ReceiveDamage(int damage);
        void Attack();
    }
}
