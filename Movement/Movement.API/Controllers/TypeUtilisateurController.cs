using Microsoft.AspNetCore.Mvc;
using Movement.Services.DepotInterfaces;
using Movement.Services.Entities;

namespace Movement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeUtilisateurController : ControllerBase
    {
        private readonly IDepotTypeUtilisateur _depot;

        public TypeUtilisateurController(IDepotTypeUtilisateur p_depot)
        {
            this._depot = p_depot;
        }

        // GET: api/<UtilisateurController>
        [HttpGet]
        public ActionResult<IEnumerable<TypeUtilisateur>> Get()
        {
            return Ok(this._depot.GetAll());
        }

        // GET api/<UtilisateurController>/5
        [HttpGet("{p_id}")]
        public ActionResult<TypeUtilisateur> Get(int p_id)
        {
            TypeUtilisateur type = this._depot.GetAll().Single(type => type.Id == p_id);

            if (type == null)
            {
                return NotFound();
            }

            return Ok(type);
        }

        // POST api/<UtilisateurController>
        [HttpPost]
        public ActionResult Post([FromBody] TypeUtilisateur p_TypeUtilisateur)
        {
            if (p_TypeUtilisateur == null || !ModelState.IsValid)
            {
                return BadRequest();
            }

            this._depot.Post(p_TypeUtilisateur);

            return Created(nameof(this.Post), p_TypeUtilisateur);
        }

        // PUT api/<UtilisateurController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] TypeUtilisateur p_TypeUtilisateur)
        {
            if (p_TypeUtilisateur == null || !ModelState.IsValid)
            {
                return BadRequest();
            }

            TypeUtilisateur type = this._depot.GetAll().Single(type => type.Id == id);

            if (type == null)
            {
                return NotFound();
            }

            this._depot.Put(type);
            return NoContent();
        }
    }
}
