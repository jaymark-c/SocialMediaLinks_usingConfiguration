using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SocialMediaLinks_usingConfig.OptionsPattern;

namespace SocialMediaLinks_usingConfig.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [Route("/")]
        public IActionResult Index()
        {
            return Json(_configuration.GetSection("Social_Media").Get<SocialMediaOptions>());
        }
    }
}
