using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ExamAutoMarkingController : ControllerBase {

        [HttpPost]
        public async Task<ActionResult<float>> MarkExamAuto([FromBody]Exam exam) {
            return Ok() ;
        }


    }
}
