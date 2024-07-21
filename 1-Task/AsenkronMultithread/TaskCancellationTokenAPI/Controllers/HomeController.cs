using Microsoft.AspNetCore.Mvc;

namespace TaskCancellationTokenAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController(ILogger<HomeController> _logger) : ControllerBase
    {
        public async Task<IActionResult> GetContentAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("İstek Başladı");
            try
            {
                await Task.Delay(5000, cancellationToken);
                Task<string>? myTask = new HttpClient().GetStringAsync("https://www.google.com", cancellationToken);
                string? data = await myTask;
                _logger.LogInformation("İstek Bitti");
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogInformation("İstek iptal edildi : " + ex.Message);
                return BadRequest(ex.Message);
            }

        }
    }
}
