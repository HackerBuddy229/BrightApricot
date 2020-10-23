using BrightApricot.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Text;

namespace BrightApricot.Server.Controllers {


    [ApiController]
    public class TestDataController : ControllerBase {

        private static string filename = "";

        [HttpGet]
        [Route("api/TestData/recipes")]
        public async Task<IActionResult> FetchTestRecipes() {
            using (var reader = File.OpenText(filename)) {
            var result = await reader.ReadToEndAsync();
            return result; 
            }
            

        } 
    }
}