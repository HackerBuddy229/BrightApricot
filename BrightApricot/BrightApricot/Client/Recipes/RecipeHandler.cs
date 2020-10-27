using System;
using BrightApricot.Client.Interfaces;
using BrightApricot.Shared.Models;
using System.Collections.Generic;
using System.Linq;

namespace BrightApricot.Client.Recipes {


    public class RecipeHandler : IRecipeHandler {


        private readonly IRecipeStorage _recipeStorage;

        public RecipeHandler(IRecipeStorage recipeStorage)
        {
            _recipeStorage = recipeStorage;

            sync();
        }
        public IEnumerable<Recipe> Recipes { get; set; }
        private IEnumerable<Recipe> recipes { get; set; }

        public void BeginCommit(){
            recipes = Recipes;
        }
        public void Commit() {
            _recipeStorage.UpdateRecipes(Recipes);
            recipes = Recipes;
        }
        public void Rollback() {
            Recipes = recipes;
        }

        private async void sync() {
            recipes = await _recipeStorage.GetRecipes();
            Recipes = recipes != null || recipes.Any() ? recipes : new List<Recipe>();
        }
    }
}