using System;
using BrightApricot.Shared.Enums;

namespace BrightApricot.Shared.Models{
    public class Ingredient {
        public string IngredientName { get; set; }
        public float amount { get; set; }
        public SIUnits Unit { get; set; }
    }
}