using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_2
{
    public class Recipe
    {
        private string name;
        public List<Ingredient> ingredients;
        public List<Steps> steps;
        private int totalCalories;
        public int scale;
       

        public string Name
        { get { return name; } 
         set { name = value; }
        }

        public List<Ingredient> Ingredients
        { get { return ingredients; } 
         set { ingredients = value; } 
        }

        public List<Steps> Steps
        { get { return steps; } 
         set { Steps = value; }
        }

        public int TotalCalories
        {
            get { return totalCalories; }
            set { totalCalories = value; }

        }




        public Recipe(string name, List<Ingredient> ingredients, List<Steps> steps)
        {
            Name = name;
            Ingredients = ingredients;
            Steps = steps;
            TotalCalories = CalculateTotalCalories();
        }

        private int CalculateTotalCalories()
        {
            int totalCalories = 0;
            foreach (Ingredient ingredient in Ingredients)
            {
                totalCalories += ingredient.Calories;
            }
            return totalCalories;
        }
    }
}

