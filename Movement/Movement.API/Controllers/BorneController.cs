using Microsoft.AspNetCore.Mvc;
using Movement.Services.DepotInterfaces;
using Movement.Services.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Movement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorneController : ControllerBase
    {
        private readonly IDepotBorne _depot;

        public BorneController(IDepotBorne p_depot)
        {
            this._depot = p_depot;
        }
        // GET: api/<BorneController>
        [HttpGet]
        public ActionResult<IEnumerable<Borne>> Get()
        {
            return Ok(this._depot.GetAll());
        }

        // GET api/<BorneController>/5
        [HttpGet("{p_id}")]
        public string Get(int p_id)
        {
            return "value";
        }

        // POST api/<BorneController>
        [HttpPost]
        public ActionResult Post([FromBody] Borne p_borne)
        {
            if (p_borne == null || !ModelState.IsValid)
            {
                return BadRequest();
            }

            this._depot.Post(p_borne);

            return Created(nameof(this.Post), p_borne);
        }

        // PUT api/<BorneController>/5
        [HttpPut("{p_id}")]
        public ActionResult Put(int p_id, [FromBody] Borne p_borne)
        {
            if (p_borne == null || !ModelState.IsValid)
            {
                return BadRequest();
            }

            Borne borne = this._depot.GetAll()
                .FirstOrDefault(b => b.Id == p_id);

            if (borne == null)
            {
                return NotFound();
            }

            borne.Intersection = p_borne.Intersection;
            borne.Latitude = p_borne.Latitude;
            borne.Longitude = p_borne.Longitude;

            this._depot.Put(borne);
            return NoContent();
        }
    }
}
