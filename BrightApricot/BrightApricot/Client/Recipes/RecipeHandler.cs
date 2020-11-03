using System;
using BrightApricot.Client.Interfaces;
using BrightApricot.Shared.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightApricot.Client.Recipes {


    public class RecipeHandler : IRecipeHandler {


        private readonly IRecipeStorage _recipeStorage;

        public RecipeHandler(IRecipeStorage recipeStorage)
        {
            _recipeStorage = recipeStorage;
        }
        public IEnumerable<Recipe> Recipes { get; set; }
        private IEnumerable<Recipe> recipes { get; set; }

        public async Task BeginCommit()
        {
            if (recipes == null)
                await Sync();   
            else
                recipes = Recipes;
        }
        public void Commit() {
            _recipeStorage.UpdateRecipes(Recipes);
            recipes = Recipes;
        }
        public void Rollback() {
            Recipes = recipes;
        }

        private async Task Sync() {
            recipes = await _recipeStorage.GetRecipes();
            Recipes = recipes != null || recipes.Any() ? recipes : new List<Recipe>();
        }
    }
}