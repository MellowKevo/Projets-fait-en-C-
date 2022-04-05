using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Evaluation_RPG.Classes
{
    public class Item 
    {
        private string name;
        private int price;

        public Item(string name, int price)
        {
            this.name = name;
            this.price = price;
            
           
        }

        public Item()
        {

        }

        

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
    }
}
