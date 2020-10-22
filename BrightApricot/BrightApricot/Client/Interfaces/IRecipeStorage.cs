using System;
using System.Collections.Generic;
using BrightApricot.Shared.Models;

namespace BrightApricot.Client.Interfaces {
    public interface IRecipeStorage {
        public IEnumerable<Recipe> GetRecipes();
        
        public void UpdateRecipes(IEnumerable<Recipe> recipes);
        public void ClearRecipes();
    }
}