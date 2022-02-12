using Microsoft.AspNetCore.Mvc;
using Movement.Services.DepotInterfaces;
using Movement.Services.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Movement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntersectionController : ControllerBase
    {
        private readonly IDepotIntersection _depot;

        public IntersectionController(IDepotIntersection p_depot)
        {
            this._depot = p_depot;
        }
        // GET: api/<IntersectionController>
        [HttpGet]
        public ActionResult<IEnumerable<Intersection>> Get()
        {
            return Ok(this._depot.GetAll()); 
        }

        // GET api/<IntersectionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<IntersectionController>
        [HttpPost]
        public ActionResult Post([FromBody] Intersection p_intersection)
        {
            if (p_intersection == null || !ModelState.IsValid)
            {
                return BadRequest();
            }

            this._depot.Post(p_intersection);
            return Created(nameof(this.Post), p_intersection);
        }

        // PUT api/<IntersectionController>/5
        [HttpPut("{p_id}")]
        public ActionResult Put(int p_id, [FromBody] Intersection p_intersection)
        {
            if (p_intersection == null || !ModelState.IsValid)
            {
                return BadRequest();
            }

            Intersection intersection = this._depot.GetAll()
                .FirstOrDefault(b => b.Id == p_id);

            if (intersection == null)
            {
                return NotFound();
            }

            intersection.Nom = p_intersection.Nom;
            intersection.Bornes = p_intersection.Bornes;

            this._depot.Put(intersection);
            return NoContent();
        }
    }
}
