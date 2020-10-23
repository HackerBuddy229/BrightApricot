using System;
using System.Collections.Generic;
using BrightApricot.Shared.Models;
using System.Threading.Tasks;

namespace BrightApricot.Client.Interfaces {
    public interface IRecipeStorage {
        public Task<IEnumerable<Recipe>> GetRecipes();
        
        public void UpdateRecipes(IEnumerable<Recipe> recipes);
        public void ClearRecipes();
    }
}