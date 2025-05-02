 using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft;
using EF_Core_Education.Models;
namespace EF_Core_Education.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        SqlConnection connection = new SqlConnection("Server=DESKTOP-B88QDOP; Database=Database1; Integrated Security=True; ");

        [HttpGet("[action]")]
        public IActionResult GetList()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From SimpleTables", connection);
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            adapter.Fill(dataTable);

            var result =Newtonsoft.Json.JsonConvert.SerializeObject(dataTable);

            return Ok(result);
        }
        [HttpPost("[action]")]
        public IActionResult Add(SimpleTable simpleTable)
        {
            SqlCommand command = new SqlCommand("insert into SimpleTables(Name) values('" + simpleTable.Name + "')", connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return Ok("Kayıt işlemi başarılı.");
        }

    }
}
