using System;
using System.Collections.Generic;

namespace Fooder.Client.Model
{
    public class FakeRecipeModel : IRecipeModel
    {
        private IList<Recipe> recipes = new List<Recipe>();
        public IList<Recipe> Recipes
        {
            get { return recipes; }
            set { recipes = value; }
        }

        public FakeRecipeModel()
        {
            GenerateRecipes();
        }

        private void GenerateRecipes()
        {
            var recipe = new Recipe();
            recipe.Name = "Non greasy gamer snacks";
            recipe.Description = "Perfect snacks for gamers wich doesn't make your hands greasy and slippery.";
            recipe.Ingredients.Add(new Ingredient{ Name = "Snack", Amount = "1 bag"});
            recipe.Ingredients.Add(new Ingredient { Name = "Non Greasy Stuff", Amount = "1 l" });

            Recipes.Add(recipe);

            recipe = new Recipe();
            recipe.Name = "Nerd burgers";
            recipe.Description = "The nerdy burger is perfect for NerdDinner(s)";
            recipe.Ingredients.Add(new Ingredient { Name = "Burger", Amount = "4" });
            recipe.Ingredients.Add(new Ingredient { Name = "Ners", Amount = "4" });

            Recipes.Add(recipe);

            recipe = new Recipe();
            recipe.Name = "Potato soup";
            recipe.Description = "Peel the potatoes. Fry the leek and onion for a short while and add water and potatoes. Boil the potatoes... etc.";
            recipe.Ingredients.Add(new Ingredient { Name = "Potatoes", Amount = "12" });
            recipe.Ingredients.Add(new Ingredient { Name = "Water", Amount = "0.6 litres" });
            recipe.Ingredients.Add(new Ingredient { Name = "Bouillon cubes (meat)", Amount = "2" });
            recipe.Ingredients.Add(new Ingredient { Name = "Onion", Amount = "1" });
            recipe.Ingredients.Add(new Ingredient { Name = "Leek", Amount = "0.5" });
            recipe.Ingredients.Add(new Ingredient { Name = "Creme fraiche", Amount = "1 dl" });
            
            Recipes.Add(recipe);
        }

        public IEnumerable<Recipe> GetAllRecipes()
        {
            return Recipes;
        }
    }
}