using Final_Exam_F2020_7243.Classes.State;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam_F2020_7243.Classes
{
    public enum Direction { NONE, UP, DOWN, LEFT, RIGHT }
   
    public class Mario : Entity
    {
        static Image image = Image.FromFile(Maze.path + "MarioSmall.png");

        private int energy;
        private int energy_max;
        private int keys;
        private int lives;
        private Direction current_Direction;
        private IState state;

        public Mario(int column, int row) : base(column, row)
        {
            this.Energy = 100;
            this.Energy_max = 100;
            this.Keys = 0;
            this.Lives = 3;
            this.Current_Direction = Direction.NONE;
            this.State =Normal_State.GetInstance();

        }

        public void Heal()
        {
            energy = energy_max;
        }

        public int Energy { get => energy; set => energy = value; }
        public int Energy_max { get => energy_max; set => energy_max = value; }
        public int Keys { get => keys; set => keys = value; }
        public int Lives { get => lives; set => lives = value; }
        public Direction Current_Direction { get => current_Direction; set => current_Direction = value; }
        public IState State { get => state; set => state = value; }


        public void LooseEnergy(int energy)
        {
            this.Energy -= energy;
            if (energy <= 0)
            {
                lives--;
            }
            if (lives <= 0)
            {
               GameController.GameOver();
            }
            else if (lives > 0)
            {
                Heal();
            }
        }

        public void OpenDoor(Entity entity)
        {


            if (entity is Item item)
            {
                if (item.ItemType == Type.DOOR)
                {
                    if (this.keys > 0)
                    {
                        this.keys--;
                        Maze.Remove_Entity(item.Row, item.Column);
                    }
                }
            }

        }
        public void Move()
        {
            Point velocity = GetVelocity();
            int next_Row = this.Row + velocity.Y;
            int next_Column = this.Column + velocity.X;
            LooseEnergy(2);

            if (Maze.CheckMazeBounds(next_Row, next_Column))
            {
                Entity next_Entity = Maze.EntityData[next_Row, next_Column];
                if (this.CanPassThrough(next_Entity))
                {
                   this.Row = next_Row;
                   this.Column = next_Column;

                   if (next_Entity is Item && ((Item)next_Entity).ItemType == Type.AWARD)
                   {
                       //Bonus : Invoke the event
                   }
                   if (next_Entity is Item && ((Item)next_Entity).ItemType == Type.POTION)
                   {
                       this.State.Drink_Potion(this);
                       Maze.Remove_Entity(this.Row, this.Column);
                   }
                   else if (next_Entity is Item && ((Item)next_Entity).ItemType == Type.KEY)
                   {
                       this.State.Take_Key(this);
                       Maze.Remove_Entity(this.Row, this.Column);
                   }
                   else if (next_Entity is Ghost && ((Ghost)next_Entity).Visible)
                   {
                       this.State.Hit_Ghost(this, (Ghost)next_Entity);
                   }

                }
                else
                {
                    OpenDoor(next_Entity);
                }
            }//end if
        }

        public bool CanPassThrough(Entity entity)
        {
            if (entity is Item && ((Item)entity).ItemType == Type.DOOR)
            {
                return false;
            }
            else
            if (entity is Tile && ((Tile)entity).Type == TileType.WALL) {
                return false;
            }
            else
            {
                return true;
            }
        }
        
        //----------------------------------------------
        public override void Draw(Graphics g)
        {
            int size = Maze.cellSize;
            Rectangle bounds = new Rectangle(this.Column * size, this.Row * size, size, size);
            g.DrawImage(image, bounds);
        }
        //------------------------------------------------
        public Point GetVelocity()
        {
            switch (this.Current_Direction)
            {
                case Direction.UP: return new Point(0, -1);
                case Direction.DOWN: return new Point(0, 1);
                case Direction.LEFT: return new Point(-1, 0);
                case Direction.RIGHT: return new Point(1, 0);
                default: return new Point(0, 0);
            }
        }
        
    }
}
