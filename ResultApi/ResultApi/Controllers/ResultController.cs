using BusinessAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedLayer;

namespace ResultApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultController : ControllerBase
    {
        private readonly IResultServices _resultServices;
        private readonly ILogger<ResultController> _logger;
        public ResultController(ILogger<ResultController> logger,IResultServices resultServices)
        {
            _resultServices = resultServices;
            _logger = logger;
        }
        [HttpGet]
        [Route("GetAllResult")]
        public IList<ResultDTO> GetAllResult()
        {
            return _resultServices.GetAllResult();
        }
        [HttpGet("GetResultBy{id}")]
        public ResultDTO GetResult(int id)
        {
            _logger.LogInformation("Inside VerifyUser Controller");
            return _resultServices.GetResult(id);
        }

        [HttpPost]
        [Route("CreateResult")]
        public void CreateResult(ResultDTO result)
        {
            _resultServices.CreateResult(result);
        }
        [HttpDelete("DeleteResultBy{id}")]
        public ActionResult<bool> DeleteResult(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            return _resultServices.DeleteResult(id);
        }
        [HttpDelete]
        [Route("DeleteAllResult")]
        public bool DeleteAll()
        {
            return _resultServices.DeleteAll();
        }
    }
}
