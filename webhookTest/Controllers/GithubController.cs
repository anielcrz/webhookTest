using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebHooks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webhookTest.Controllers
{
    [Route("wb")]
    [ApiController]
    public class GithubController : ControllerBase
    {
        [GitHubWebHook]
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
