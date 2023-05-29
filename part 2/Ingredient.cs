using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_2
{
    public class Ingredient
    {
        public string name;
      public string recipe;
        public double quantity;
        public string unit;
        public int calories;
        public string foodGroup;
        public int numIngredients;
        

        public string Name
        {
            get { return name; }    
            set { name = value; }
        }

        public string Recipe
        {
            get { return FoodGroup; }
            set { FoodGroup = value; }
        }

        public double Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        public int Calories
        {
            get { return calories ; }
            set { calories= value; }
        }

        public string FoodGroup
        {
            get { return FoodGroup; }
            set { FoodGroup = value; }
        }

        public int NumIngredients
        {
            get { return numIngredients; }
            set { numIngredients = value; }
        }
    }

}
