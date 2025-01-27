using Emne_8_Cloud.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Emne_8_Cloud.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DbController(IMediator mediator, ILogger<DbController> logger) : ControllerBase
    {
       [HttpGet("GetAll")]
       public async Task<IActionResult> GetAllFromDb([FromQuery]GetAllRequest request)
        {
            var result = await mediator.Send(request);
            return Ok(result);
        }
        [HttpPost("AddRecord")]
        public async Task<IActionResult> AddRecordToDb([FromBody] AddRecordRequest request)
        { 
            var result = await mediator.Send(request);
            return Ok(result);
        }
        [HttpDelete("DeleteById/{id}")]
        public async Task<IActionResult> DeleteFromDbById(int id)
        {
            var request = new DeleteByIdRequest { Id = id };
            var result = await mediator.Send(request);
            return Ok(result);
        }
        [HttpPut("UpdateRecordById/{id}")]
        public async Task<IActionResult> GetAllFromDb(int id)
        {
            var request = new UpdateRecordByIdRequest { Id = id };
            var result = await mediator.Send(request);
            return Ok(result);
        }
    }
}
