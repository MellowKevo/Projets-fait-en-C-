using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam_F2020_7243.Classes
{
    public enum Type { AWARD, DOOR, KEY, POTION, WALL }

    public class Item : Entity
    {
        private Type itemType;
        private string fileName;
        public Type ItemType { get => itemType; set => itemType = value; }
        
        public Item(int row, int colum, string imageFile, Type type) : base(row, colum) 
        {
            this.fileName = imageFile;
            this.ItemType = type;
        }
       
        public override void Draw(Graphics g)
        {
            int size = Maze.cellSize;
            Rectangle bounds = new Rectangle(this.Column * size, this.Row * size, size, size );
            
            using (Image image = Image.FromFile(this.fileName)) {
                g.DrawImage(image, bounds);
            } 
        }
    }
}
