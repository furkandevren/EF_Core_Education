using EFCodeFirstEducation.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCodeFirstEducation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        Deneme2Context context=new Deneme2Context();
        [HttpGet("[action]")]
        public IActionResult GetList()
        {
            var result=context.Furkans.ToList();
            return Ok(result);
        }
    }
}
