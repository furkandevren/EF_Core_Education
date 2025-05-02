using EF_Core_Education.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EF_Core_Education.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EFController : ControllerBase
    {
        DenemeContext context = new();

        [HttpGet("[action]")]
        public IActionResult GetList()
        {
            var result = context.SimpleTables.ToList();
            return Ok(result);
        }
        [HttpPost("[action]")]
        public IActionResult Add(SimpleTable simpleTable)
        {
            context.SimpleTables.Add(simpleTable);
            context.SaveChanges();

            return Ok("Kayıt işlemi başarıyla sağlandı.");
        }
        [HttpPost("[action]")]
        public IActionResult Update(SimpleTable simpleTable)
        {
            context.SimpleTables.Update(simpleTable);
            context.SaveChanges();

            return Ok("Güncelleme işlemi başarıyla tamamlandı.");
        }
        [HttpPost("[action]")]
        public IActionResult Remove(SimpleTable simpleTable)
        {
            context.SimpleTables.Remove(simpleTable);
            context.SaveChanges();

            return Ok("Silme işlemi başarıyla tamamlandı.");
        }

        [HttpPost("[action]")]
        public IActionResult DeleteRange(SimpleTable[] simpleTables)
        {
            context.SimpleTables.RemoveRange(simpleTables);
            context.SaveChanges();

            return Ok("Çoklu silme işlemi başarılı.");
        }
    }
}