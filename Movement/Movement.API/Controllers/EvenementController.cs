using Microsoft.AspNetCore.Mvc;
using Movement.Services.DepotInterfaces;
using Movement.Services.Entities;

namespace Movement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EvenementController : ControllerBase
    {
        private readonly IDepotEvenement _depot;

        public EvenementController(IDepotEvenement p_depot)
        {
            this._depot = p_depot;
        }

        // GET: api/<EvenementController>
        [HttpGet]
        public ActionResult<IEnumerable<Evenement>> Get()
        {
            return Ok(this._depot.GetAll());
        }

        // GET api/<Evenement>/5
        [HttpGet("{p_id}")]
        public ActionResult<Evenement> Get(int p_id)
        {
            return Ok(this._depot.GetEvenementByIntersectionId(p_id));
        }

        // POST api/<ActionFeuController>
        [HttpPost]
        public ActionResult Post([FromBody] Evenement p_Evenement)
        {
            if (p_Evenement == null || !ModelState.IsValid)
            {
                return BadRequest();
            }

            this._depot.Post(p_Evenement);

            return Created(nameof(this.Post), p_Evenement);
        }
    }
}
