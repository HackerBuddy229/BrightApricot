using BrightApricot.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace BrightApricot.Server.Controllers {


    [ApiController]
    [Route("api/TestData")]
    public class TestDataController : ControllerBase {

        private readonly IConfiguration _configuration;


        private readonly string _filename;

        public TestDataController(IConfiguration configuration)
        {
            _configuration = configuration;

            _filename = _configuration.GetSection("Paths").GetValue<string>("TestData");
        }


        

        [HttpGet]
        [Route("recipes")]
        public IActionResult FetchTestRecipes() {
            //var result = await System.IO.File.ReadAllTextAsync(_filename);
            var result = StaticTestData.Data;
            return Ok(result);
        } 
    }
}