using System;
using System.Collections.Generic;
using BrightApricot.Shared.Models;

namespace BrightApricot.Client.Interfaces {


    public interface IRecipeHandler {
        public IEnumerable<Recipe> Recipes { get; set; }

        public void BeginCommit();
        public void Commit();
        public void Rollback();
    }
}