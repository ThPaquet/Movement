using Microsoft.AspNetCore.Mvc;
using Movement.Services.DepotInterfaces;
using Movement.Services.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Movement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TraversePietonController : ControllerBase
    {
        private readonly IDepotTraversePieton _depot;
        public TraversePietonController(IDepotTraversePieton p_depot)
        {
            this._depot = p_depot;
        }
        // GET: api/<TraversePietonController>
        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult<List<TraversePieton>> Get()
        {
            return Ok(this._depot.GetAll());
        }

        // POST api/<TraversePietonController>
        [HttpPost]

        public ActionResult Post([FromBody] TraversePieton p_traverse)
        {
            if (p_traverse == null || !ModelState.IsValid)
            {
                return BadRequest();
            }

            this._depot.Post(p_traverse);

            return Created(nameof(this.Post), p_traverse);
        }
    }
}
