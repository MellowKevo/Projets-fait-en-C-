using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam_F2020_7243.Classes
{
    public class Ghost : Entity
    {
        public bool visible;
        public Image image = Image.FromFile(Maze.path + "boo.jpg");

        public Ghost(int column, int row) : base(column, row)
        {
            this.Visible = true;
        }

        public void Hide()
        {
            this.Visible = false;
        }

        public void Show()
        {
            this.Visible = true;
        }


        public bool Visible { get => visible; set => visible = value; }

        public override void Draw(Graphics g)
        {
            if (this.Visible)
            {
                int size = Maze.cellSize;
                Rectangle bounds = new Rectangle(this.Column * size, this.Row * size, size, size);
                g.DrawImage(image, bounds);
            }
        }
    }
}
