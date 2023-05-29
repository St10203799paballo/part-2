using part_2;
using System.Xml.Linq;

public class Program
{
    //Recipe rec = new Recipe();
    List<Recipe> rec = new List<Recipe>();
   
    public static void Main(string[] args)
    {
      

        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Welcome to Recipe Manager!");
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. Add a recipe");
                Console.WriteLine("2. Remove a recipe");
                Console.WriteLine("3. Display recipe list");
                Console.WriteLine("4. Display recipe details");
                Console.WriteLine("5. Scale recipe");
                Console.WriteLine("6. Reset recipe quantities");
                Console.WriteLine("7. Clear all data");
                Console.WriteLine("8. Exit");

                String choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddRecipe();
                        break;
                    case "2":
                        RemoveRecipe();
                        break;
                    case "3":
                        DisplayRecipeList();
                        break;
                    case "4":
                        DisplayRecipeDetails();
                        break;
                    case "5":
                        ScaleRecipe();
                        break;
                    case "6":
                        ResetRecipeQuantities();
                        break;
                    case "7":
                        ClearAllData();
                        break;
                    case "8":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }



                Console.WriteLine("Enter number of ingredients:");
                int numIngredients = int.Parse(Console.ReadLine());

                Console.WriteLine();
            }
        }
    }
            public static void AddRecipe()

            {
        Ingredient grid = new Ingredient();

        Console.WriteLine("Enter recipe name:");
                string name = Console.ReadLine();

                for (int i = 0; i < grid.numIngredients; i++)
                {
                    Console.WriteLine($"Enter ingredient {i + 1} name:");
                    string ingredientName = Console.ReadLine();

                    Console.WriteLine($"Enter ingredient {i + 1} quantity:");
                    double quantity = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Enter ingredient {i + 1} unit of measurement:");
                    string unitOfMeasurement = Console.ReadLine();

                    Console.WriteLine($"Enter ingredient {i + 1} calories:");
                    int calories = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Enter ingredient {i + 1} food group:");
                    string foodGroup = Console.ReadLine();

                    Ingredient more = new Ingredient();
                    more.Name = ingredientName;
                    more.Quantity = quantity;
                    more.Unit = unitOfMeasurement;
                    more.Calories = calories;
                    more.FoodGroup = foodGroup;
            //rec.AddIngredients(ingredientName, quantity, unitOfMeasurement, calories, foodGroup);
                Recipe recipe = new Recipe();
                }
            
                Console.WriteLine("Enter number of steps:");
                int numSteps = int.Parse(Console.ReadLine());

                for (int i = 0; i < numSteps; i++)
                {
                    Console.WriteLine($"Enter step {i + 1} description:");
                    string description = Console.ReadLine();

                    recipe.AddSteps(description);
                }

                RcManager.AddRecipe(recipe);

                Console.WriteLine($"Recipe '{name}' added successfully!");
            }

            public static void RemoveRecipe()
            {
                Console.WriteLine("Enter recipe name to remove:");
                string name = Console.ReadLine();

                if (RcManager.RemoveRecipe(name))
                {
                    Console.WriteLine($"Recipe '{name}' removed successfully!");
                }
                else
                {
                    Console.WriteLine($"Recipe '{name}' not found!");
                }
            }

            public static void DisplayRecipeList()
            {
                Console.WriteLine("Recipe list:");
                foreach (Recipe recipe in RcManager.GetRecipeList())
                {
                    Console.WriteLine(recipe.Name);
                }
            }

            public static void DisplayRecipeDetails()
            {
                Console.WriteLine("Enter recipe name to display details:");
                string name = Console.ReadLine();

                Recipe recipe = RcManager.GetRecipeList(name);

                if (recipe != null)
                {
                    Console.WriteLine($"Recipe'{{name}}' details:");
                    Console.WriteLine($"Ingredients:");
                    foreach (Ingredient ingredient in recipe.Ingredients)
                    {
                        Console.WriteLine($" - {  ingredient.Name} : {  ingredient.Quantity}  {  ingredient.Unit} , {  ingredient.Calories}  calories, {  ingredient.FoodGroup}  food group");
                    }
                    Console.WriteLine($"Steps:");
                    foreach (string step in recipe.Steps)
                    {
                        Console.WriteLine($"- {{step}}");
                    }
                    Console.WriteLine($"Total calories: {{recipe.TotalCalories}}");
                    if (recipe.TotalCalories > 300)
                    {
                        Console.WriteLine("WARNING: Recipe exceeds 300 calories!");
                    }
                }
                else
                {
                    Console.WriteLine($"Recipe '{{name}}' not found!");
                }
            }
                public static void ScaleRecipe()
                {
            Console.WriteLine("Enter recipe name to scale: ");
            string name = Console.ReadLine();
            RcManager recipe1 = RcManager.GetRecipeList(name);
            if (recipe1 != null)
            {
                Console.WriteLine($"Recipe '{{name}}' current scale factor: {{recipe.ScaleFactor}}");
                Console.WriteLine("Enter new scale factor (0.5, 2, or 3):");
                double newScaleFactor = double.Parse(Console.ReadLine());
                recipe1.Scale(newScaleFactor);
                Console.WriteLine($"Recipe '{{name}}' scaled successfully!");
            DisplayRecipeDetails();
        }
                 
            else
            {
                Console.WriteLine($"Recipe '{{name}}' not found!");
            }
                }
                public static void ResetRecipeQuantities()
                {
                    Console.WriteLine("Enter recipe name to reset quantities:");
                    string recipeName = Console.ReadLine();
                    Recipe recipe = RcManager.GetRecipeByName(recipeName);
                    if (recipe == null)
                        Console.WriteLine("Recipe not found!");
                    return;

                 Console.WriteLine("Recipe quantities reset successfully!:");
                }

    public static void ClearAllData()
    {
        Console.WriteLine("Are you sure you want to clear all data? (Y/N)");
        string answer = Console.ReadLine().ToUpper();
        if (answer == "Y")
        {
            RcManager.ClearRecipes();

            Console.WriteLine("All data has been cleared.");
        }
        else
            Console.WriteLine("Operation cancelled.");
    }






}
        
    