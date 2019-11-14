using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SufjanAsAService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SufjanController : ControllerBase
    {
        private readonly ILogger<SufjanController> _logger;

        public SufjanController(ILogger<SufjanController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            List<string> Lyrics = new List<string>();
            for(int i = 0; i < Program.markovChain.GenerateSentence().Length * 2; i++)
            {
                Lyrics.Add(Program.markovChain.GenerateSentence());
            }
            return String.Join("\n", Lyrics);
        }
    }
}
