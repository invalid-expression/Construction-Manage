using ConstructionManageAPI.Interface;
using ConstructionManageAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConstructionManageAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObservationController : ControllerBase
    {
        private readonly IObservation _observation;
        public ObservationController(IObservation observation)
        {
            _observation = observation;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ObservationEntity>>> GetDepartment()
        {
            var data = await _observation.GetObservation();
            return Ok(data);
        }
    }
}
