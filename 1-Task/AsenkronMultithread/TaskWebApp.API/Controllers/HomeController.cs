using Microsoft.AspNetCore.Mvc;

namespace TaskWebApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetContentAsync()
        {
            Task<string>? myTask = new HttpClient().GetStringAsync("https://www.google.com");

            string? data = await myTask;
            return Ok(data);
        }
    }
}
