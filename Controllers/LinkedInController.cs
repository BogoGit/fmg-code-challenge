using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using fmg_demo_master;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace demoapp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LinkedInController : ControllerBase
    {
        private readonly ILogger<LinkedInController> _logger;
        private readonly ILinkedInService _linkedInService;

        public LinkedInController(ILogger<LinkedInController> logger, ILinkedInService linkedInService)
        {
            _logger = logger;
            _linkedInService = linkedInService;
        }

        [HttpGet]
        public async Task<string> Get()
        {
            // Using typed HttpClient
            return await _linkedInService.Get();
        }

        public class LinkedInProfile
        {
            public string Name { get; set; }
            public string PageUrl { get; set; }
        }
    }
}
