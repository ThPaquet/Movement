using Microsoft.AspNetCore.Mvc;
using Movement.Services.DepotInterfaces;
using Movement.Services.Entities;
using Newtonsoft.Json;
using Movement_API;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Movement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActionFeuController : ControllerBase
    {
        private readonly IDepotActionFeu _depot;

        public ActionFeuController(IDepotActionFeu p_depot)
        {
            this._depot = p_depot;
        }
        // GET: api/<ActionFeuController>
        [HttpGet]
        public ActionResult<IEnumerable<ActionFeu>> Get()
        {
            return Ok(this._depot.GetAll());
        }

        // GET api/<ActionFeuController>/5
        [HttpGet("{p_requete}")]
        public ActionResult<float> Get(string p_requete)
        {
            var sampleData = new MLModel.ModelInput()
            {
                TypeUtilisateur = 3,
                Date = "2021-04-10 07:10:35",
                LongitudeBorneDepart = 46.846234f,
                LongitudeBorneArrivee = 46.846272f,
                LatitudeBorneDepart = -71.37293f,
                LatitudeBorneArrivee = -71.37293f
            };

            var result = MLModel.Predict(sampleData);

            return Ok(result.Score);
        }

        // POST api/<ActionFeuController>
        [HttpPost]
        public ActionResult Post([FromBody] ActionFeu p_actionFeu)
        {
            if (p_actionFeu == null || !ModelState.IsValid)
            {
                return BadRequest();
            }

            this._depot.Post(p_actionFeu);

            return Created(nameof(this.Post), p_actionFeu);
        }

        // PUT api/<ActionFeuController>/5
        [HttpPut("{p_id}")]
        public ActionResult Put(int p_id, [FromBody] ActionFeu p_actionFeu)
        {
            if (p_actionFeu == null || !ModelState.IsValid)
            {
                return BadRequest();
            }

            ActionFeu actionFeu = this._depot.GetAll()
                .FirstOrDefault(a => a.Id == p_id);

            if (actionFeu == null)
            {
                return NotFound();
            }

            actionFeu.Type = p_actionFeu.Type;

            this._depot.Put(actionFeu);
            return NoContent();
        }
    }
}
