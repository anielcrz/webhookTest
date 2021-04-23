using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebHook.Controllers
{
    [Route("[Controller]")]
    public class WhController : Controller
    {
        public IActionResult Index()
        {
            return Ok("Everything is fine!");
        }

        [HttpPost("")]
        public async Task<IActionResult> Receive()
        {
            Request.Headers.TryGetValue("token", out StringValues Token);


            using (var reader = new StreamReader(Request.Body))
            {
                var txt = await reader.ReadToEndAsync();
                
                if(Token == "83699ec7c1d794c0c780e49a5c72972590571fd8")
                    return Ok(txt);

            }

            return Unauthorized();


        }

        
    }
}
