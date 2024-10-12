using globalblue1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Linq.Expressions;

namespace globalblue1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculateController : ControllerBase
    {
        [HttpPost]
        [ApiKeyAuthorize]
        public IActionResult Calculate([FromBody] string mathRequest)
        {
            try
            {
                var table = new DataTable();
                var result = Convert.ToDecimal(table.Compute(mathRequest, string.Empty));
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
