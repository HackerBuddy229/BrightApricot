using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BrightApricot.Shared.Models;

namespace BrightApricot.Client.Interfaces {


    public interface IRecipeHandler {
        public IEnumerable<Recipe> Recipes { get; set; }
        public Task BeginCommit();
        public void Commit();
        public void Rollback();
    }
}