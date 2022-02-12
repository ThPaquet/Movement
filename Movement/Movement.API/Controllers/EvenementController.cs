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
        [HttpGet]
        public IEnumerable<Evenement> Get(int id)
        {
            return (IEnumerable<Evenement>)Ok(this._depot.GetEvenementByIntersectionId(id));
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
