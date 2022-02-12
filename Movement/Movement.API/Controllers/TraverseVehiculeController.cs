using Microsoft.AspNetCore.Mvc;
using Movement.Services.DepotInterfaces;
using Movement.Services.Entities;

namespace Movement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TraverseVehiculeController : ControllerBase
    {
        private readonly IDepotTraverseVehicule _depot;

        public TraverseVehiculeController(IDepotTraverseVehicule p_depot)
        {
            this._depot = p_depot;
        }

        // GET: api/<TraversePietonController>
        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult<List<TraverseVehicule>> Get()
        {
            return Ok(this._depot.GetAll());
        }

        // POST api/<TraversePietonController>
        [HttpPost]

        public ActionResult Post([FromBody] TraverseVehicule p_traverse)
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
