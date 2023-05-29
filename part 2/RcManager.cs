using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_2
{
    public class RcManager
    {
        
        public List<Recipe> recipes;

        public RcManager()
        {
            recipes = new List<Recipe>();
        }

        public void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }

        public void RemoveRecipe(Recipe recipe)
        {
            recipes.Remove(recipe);
        }

        public List<Recipe> GetRecipeList(string? name)
        {
            return recipes;
        }

        public Recipe GetRecipeByName(string name)
        {
            foreach (Recipe recipe in recipes)
            {
                if (recipe.Name == name)
                {
                    return recipe;
                }
            }
            return null;
        }
    }
}
