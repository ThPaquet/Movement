using Microsoft.AspNetCore.Mvc;
using Movement.Services.DepotInterfaces;
using Movement.Services.Entities;

namespace Movement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeTransportController : ControllerBase
    {
        private readonly IDepotTypeTransport _depot;

        public TypeTransportController(IDepotTypeTransport p_depot)
        {
            this._depot = p_depot;
        }

        // GET: api/<UtilisateurController>
        [HttpGet]
        public ActionResult<IEnumerable<TypeTransport>> Get()
        {
            return Ok(this._depot.GetAll());
        }

        // GET api/<UtilisateurController>/5
        [HttpGet("{p_id}")]
        public ActionResult<TypeTransport> Get(int p_id)
        {
            TypeTransport type = this._depot.GetAll().Single(type => type.Id == p_id);

            if (type == null)
            {
                return NotFound();
            }

            return Ok(type);
        }

        // POST api/<UtilisateurController>
        [HttpPost]
        public ActionResult Post([FromBody] TypeTransport p_TypeTransport)
        {
            if (p_TypeTransport == null || !ModelState.IsValid)
            {
                return BadRequest();
            }

            this._depot.Post(p_TypeTransport);

            return Created(nameof(this.Post), p_TypeTransport);
        }

        // PUT api/<UtilisateurController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] TypeTransport p_TypeTransport)
        {
            if (p_TypeTransport == null || !ModelState.IsValid)
            {
                return BadRequest();
            }

            TypeTransport type = this._depot.GetAll().Single(type => type.Id == id);

            if (type == null)
            {
                return NotFound();
            }

            this._depot.Put(type);
            return NoContent();
        }
    }
}
