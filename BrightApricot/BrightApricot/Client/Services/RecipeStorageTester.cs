using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

using BrightApricot.Shared.Models;
using BrightApricot.Client.Interfaces;

namespace BrightApricot.Client.Services {
    public class RecipeStorageTester : IRecipeStorage {


        private readonly HttpClient _httpClient;
        private readonly Uri _uri = 
            new Uri("https://localhost:5001/api/TestData/recipes"); // 


        private IEnumerable<Recipe> Recipes { get; set; } 

        public RecipeStorageTester(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Recipe>> GetRecipes() {
            if (Recipes == null)
                await PopulateStorage();
            return Recipes;
        }
        
        public void UpdateRecipes(IEnumerable<Recipe> recipes) {
            Recipes = recipes;
        }
        public void ClearRecipes() {
            Recipes = Recipes.Where(x => false).ToList();
        }

        private async Task<string> FetchJson() {
            var result = await _httpClient.GetAsync(_uri);
            if (result.IsSuccessStatusCode)
                return await result.Content.ReadAsStringAsync();
            return string.Empty;
            
        }

        private void FillStorageByJson(string json) {
            var recipe = JsonSerializer.Deserialize<IEnumerable<Recipe>>(json);
            Recipes = recipe;
        }

        private async Task PopulateStorage() {
            var result = await FetchJson();
            if (!string.IsNullOrWhiteSpace(result))
                FillStorageByJson(result);
            else
                Recipes = new List<Recipe>();
        }
    }
}