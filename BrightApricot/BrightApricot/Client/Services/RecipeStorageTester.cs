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
        private static string _url = "api/TestData/recipes"; // 


        private IEnumerable<Recipe> _recipes { get; set; } 

        public RecipeStorageTester(HttpClient httpClient)
        {
            _httpClient = httpClient;

            PopulateStorage();
        }
        public Task<IEnumerable<Recipe>> GetRecipes() {
            return Task.FromResult(_recipes);
        }
        
        public void UpdateRecipes(IEnumerable<Recipe> recipes) {
            _recipes = recipes;
        }
        public void ClearRecipes() {
            _recipes = _recipes.Where(x => false).ToList();
        }

        private async Task<string> FetchJson() {
            var result = await _httpClient.GetAsync(_url);
            if (result.IsSuccessStatusCode)
                return await result.Content.ReadAsStringAsync();
            return string.Empty;
            
        }

        private void FillStorageByJson(string json) {
            var recipe = JsonSerializer.Deserialize<IEnumerable<Recipe>>(json);
            _recipes = recipe;
        }

        private async void PopulateStorage() {
            var result = await FetchJson();
            if (!string.IsNullOrWhiteSpace(result))
                FillStorageByJson(result);
            else
                _recipes = new List<Recipe>();
        }
    }
}