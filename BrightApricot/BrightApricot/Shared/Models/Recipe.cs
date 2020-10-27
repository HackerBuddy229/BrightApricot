using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BrightApricot.Shared.Models {
    public class Recipe
    {
        [Key] 
        public string Id { get; set; } = Guid.NewGuid().ToString();
        
        public string Title { get; set; }
        public string Description { get; set; }

        public string ImageFileType { get; set; }
        public string Base64Image { get; set; }


        public IEnumerable<Ingredient> Ingredients { get; set; }
        public IEnumerable<Instruction> Instructions { get; set; }
    }
}