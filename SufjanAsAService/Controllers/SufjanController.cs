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
            return "Hi!";
        }
    }
}
