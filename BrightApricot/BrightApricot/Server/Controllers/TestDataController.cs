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
            var result = await System.IO.File.ReadAllTextAsync(filename);
            return Ok(result);
        } 
    }
}