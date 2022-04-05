using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam_F2020_7243.Classes
{
    public abstract class Entity
    {
        private int row;
        private int column;

        protected Entity(int row, int column)
        {
            this.row = row;
            this.column = column;
        }

        public int Row { get => row; set => row = value; }
        public int Column { get => column; set => column = value; }

        public abstract void Draw(Graphics g);
    }
}
