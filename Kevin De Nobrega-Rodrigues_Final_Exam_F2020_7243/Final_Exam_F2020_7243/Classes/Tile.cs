using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam_F2020_7243.Classes
{
    public enum TileType { FLOOR, WALL}

    public class Tile : Entity
    {
        private Color myColor;
        private TileType type;
        
        public Tile(int row, int colum, Color color, TileType type) : base(row, colum) 
        {
            this.myColor = color;
            this.type = type;
        }

        public TileType Type { get => type; set => type = value; }
        
        public override void Draw(Graphics g)
        {
            int size = Maze.cellSize / 2;
            Rectangle bounds = new Rectangle(this.Column * size * 2 + (size / 2), this.Row * size * 2 + (size / 2), size, size);
            Brush brush = new SolidBrush(this.myColor);
            g.FillRectangle(brush, bounds);
            brush.Dispose();
        }
    }
}
