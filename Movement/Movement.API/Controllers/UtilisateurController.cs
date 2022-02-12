using Microsoft.AspNetCore.Mvc;
using Movement.Services.DepotInterfaces;
using Movement.Services.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Movement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateurController : ControllerBase
    {
        private readonly IDepotUtilisateur _depot;

        public UtilisateurController(IDepotUtilisateur p_depot)
        {
            this._depot = p_depot;
        }
        // GET: api/<UtilisateurController>
        [HttpGet]
        public ActionResult<IEnumerable<Utilisateur>> Get()
        {
            return Ok(this._depot.GetAll());
        }

        // GET api/<UtilisateurController>/5
        [HttpGet("{p_id}")]
        public ActionResult<Utilisateur> Get(int p_id)
        {
            Utilisateur utilisateur = this._depot.GetUtilisateurById(p_id);

            if (utilisateur == null)
            {
                return NotFound();
            }

            return Ok(utilisateur);
        }

        // POST api/<UtilisateurController>
        [HttpPost]
        public ActionResult Post([FromBody] Utilisateur p_utilisateur)
        {
            if (p_utilisateur == null || !ModelState.IsValid)
            {
                return BadRequest();
            }

            this._depot.Post(p_utilisateur);

            return Created(nameof(this.Post), p_utilisateur);
        }

        // PUT api/<UtilisateurController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int p_id, [FromBody] Utilisateur p_utilisateur)
        {
            if (p_utilisateur == null || !ModelState.IsValid)
            {
                return BadRequest();
            }

            Utilisateur utilisateur = this._depot.GetUtilisateurById(p_id);

            if (utilisateur == null)
            {
                return NotFound();
            }

            utilisateur.TypeUtilisateur = p_utilisateur.TypeUtilisateur;
            utilisateur.Cle = p_utilisateur.Cle;

            this._depot.Put(utilisateur);
            return NoContent();
        }
    }
}
