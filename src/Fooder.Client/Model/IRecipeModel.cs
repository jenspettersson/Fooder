using System.Collections.Generic;

namespace Fooder.Client.Model
{
    public interface IRecipeModel
    {
        IEnumerable<Recipe> GetAllRecipes();
    }
}