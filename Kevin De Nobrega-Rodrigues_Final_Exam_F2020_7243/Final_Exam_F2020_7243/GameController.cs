using Final_Exam_F2020_7243.Classes;
using Final_Exam_F2020_7243.Classes.State;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Exam_F2020_7243
{
    public partial class GameController : Form
    {
        public static Mario mario = null;
        public static List<Ghost> list_ghosts = new List<Ghost>();

        public GameController()
        {
            InitializeComponent();
            //mario = new Mario(0,9);
            Maze.LoadData();
            int max_row = Maze.EntityData.GetUpperBound(0) + 1;
            int max_col = Maze.EntityData.GetUpperBound(1) + 1;
            this.ClientSize = new Size(max_col * Maze.cellSize, max_row * Maze.cellSize + 70);
            this.pictureBox1.Size = new Size(max_col * Maze.cellSize, max_row * Maze.cellSize);
        }
        
        public static void GameOver()
        {
            GameOver form = new GameOver();
            form.Show();
        }
        public static void GameWinner()
        {
            GameAward form = new GameAward();
            form.Show();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Entity entity in Maze.EntityData)
            {
                if (entity != null)
                {
                    //entity.Draw(e.Graphics);
                }
            }
            //mario.Draw(e.Graphics);

            //label_Lives.Text = GameController.mario.Lives.ToString();
            //label_Destroyer.Text = GameController.mario.Keys.ToString();
            //this.label_Energy.Text = GameController.mario.Energy.ToString();
            //Display_Energy_Picture(GameController.mario.Energy);
            Display_State();
            Display_Direction();
        }

        private void GameController_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                  //  GameController.mario.Current_Direction = Direction.UP;
                    break;
                case Keys.Down:
                 //   GameController.mario.Current_Direction = Direction.DOWN;
                    break;
                case Keys.Left:
                  //  GameController.mario.Current_Direction = Direction.LEFT;
                    break;
                case Keys.Right:
                  //  GameController.mario.Current_Direction = Direction.RIGHT;
                    break;
                default:
                  //  GameController.mario.Current_Direction = Direction.NONE;
                    break;
            }
           // GameController.mario.Move();
            this.pictureBox1.Refresh();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Ghost obj in GameController.list_ghosts)
            {
                //obj.Show();
            }
            int random1 = RNG.Get_Instance().Next(GameController.list_ghosts.Count);
            //GameController.list_ghosts[random1].Hide();

            int random2 = RNG.Get_Instance().Next(GameController.list_ghosts.Count);
            //GameController.list_ghosts[random2].Hide();
            this.pictureBox1.Refresh();
        }

        private void Display_Energy_Picture(int e)
        {
            if (e >= (0.75 * 100))
            {
                this.picture_energy.Image = Image.FromFile(Maze.path + "green_battery.png");
                this.label_Energy.ForeColor = Color.GreenYellow;
            }
            else
            if (e >= (0.5 * 100))
            {
                this.picture_energy.Image = Image.FromFile(Maze.path + "yellow_battery.png");
                this.label_Energy.ForeColor = Color.Gold;
            }
            else
            if (e >= (0.25 * 100))
            {
                this.picture_energy.Image = Image.FromFile(Maze.path + "orange_battery.png");
                this.label_Energy.ForeColor = Color.Orange;
            }
            else
            {
                this.picture_energy.Image = Image.FromFile(Maze.path + "red_battery.png");
                this.label_Energy.ForeColor = Color.Red;
            }

        }
        public void Display_Direction()
        {/*
            string dir = "";
            switch (GameController.mario.Current_Direction)
            {
                case Direction.UP:
                    dir = "UP";
                    break;
                case Direction.DOWN:
                    dir = "DOWN";
                    break;
                case Direction.LEFT:
                    dir = "LEFT";
                    break;
                case Direction.RIGHT:
                    dir = "RIGHT";
                    break;
                default:
                    dir = "NONE";
                    break;
            }
            label_Direction.Text = dir;
            */
        }
        public void Display_State()
        {
            /*
            if (GameController.mario.State is Normal_State)
            {
                label_State.Text = "Normal";
            }
            else
            {
                label_State.Text = "Super";
            }*/

        }
    }
}
