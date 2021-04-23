using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebHooks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebHook.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GithubController : ControllerBase
    {   
        [HttpPost]
        public IActionResult GitHubHandler(JObject data)
        {
            var result = JsonConvert.SerializeObject(data);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Tudo Certo!");
        }
    }
}


