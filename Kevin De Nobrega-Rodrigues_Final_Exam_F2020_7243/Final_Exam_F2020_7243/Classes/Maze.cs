using System;
using System.IO;
using System.Drawing;


namespace Final_Exam_F2020_7243.Classes
{
    public class Maze
    {
        public static string path = "../../Images/";
        public static Entity[,] EntityData = null;
        public static int cellSize = 40;


        public static void LoadData()
        {
            string[] fileLines = File.ReadAllLines(path + "Maze.txt");
            int nbrRows = fileLines.Length;
            int nbrCols = fileLines[0].Length;

            //Initialize the static variables with empty Matrices
            EntityData = new Entity[nbrRows, nbrCols];

            //Parse the Text File
            int row = 0;

            foreach (string line in fileLines)
            {
                char[] chars = line.ToCharArray();
                int col = 0;

                foreach (char aChar in chars)
                {
                    switch (aChar)
                    {
                        case 'A': //Award
                            EntityData[row, col] = new Item(row, col, path + "Award.png", Type.AWARD);
                            break;
                        case 'G': //Ghost
                           Ghost obj = new Ghost(row, col);
                            EntityData[row, col] = obj;
                           GameController.list_ghosts.Add(obj);
                            break;
                    
                        case '.': //Floor
                            EntityData[row, col] = new Tile(row, col, Color.Black, TileType.FLOOR);
                            break;
                        case 'P': //Potion
                            EntityData[row, col] = new Item(row, col, path + "potion.png", Type.POTION);
                            break;
                        case 'K': //Key
                           EntityData[row, col] = new Item(row, col, path + "Key.png", Type.KEY);
                            break;
                        case 'D': //Door
                           EntityData[row, col] = new Item(row, col, path + "door.png", Type.DOOR);
                            break;
                        case '#': //Wall
                            EntityData[row, col] = new Tile(row, col, Color.LightGray, TileType.WALL);
                            break;
                    }
                    col++;
                }
                row++;
            }
        }
        public static void Remove_Entity(int row, int col)
        {
            Entity entity = EntityData[row, col];
            EntityData[row, col] = new Tile(row, col, Color.Black, TileType.FLOOR);
        }
        public static bool CheckMazeBounds(int row, int col)
        {
            int max_row = EntityData.GetUpperBound(0);
            int max_col = EntityData.GetUpperBound(1);

            if (row < 0 || row > max_row)
            {
                return false;
            }
            if (col < 0 || col > max_col)
            {
                return false;
            }
            return true;
        }
    }
}
