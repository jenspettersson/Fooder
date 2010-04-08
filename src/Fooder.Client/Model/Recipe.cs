using System.Collections.Generic;

namespace Fooder.Client.Model
{
    public class Recipe
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<Ingredient> Ingredients { get; set; }

        public Recipe()
        {
            Ingredients = new List<Ingredient>();
        }
    }
}