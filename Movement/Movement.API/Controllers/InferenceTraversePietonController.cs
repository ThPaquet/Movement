using Microsoft.AspNetCore.Mvc;
using Movement.Services.DepotInterfaces;
using Movement.Services.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Movement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InferenceTraversePietonController : ControllerBase
    {
        private readonly IDepotInferenceTraversePieton _depot;

        public InferenceTraversePietonController(IDepotInferenceTraversePieton p_depot)
        {
            this._depot = p_depot;
        }
        // GET: api/<InferenceTraversePietonController>
        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult<IEnumerable<InferenceTraversePieton>> Get()
        {
            return Ok(this._depot.GetAll());
        }

        // GET api/<InferenceTraversePietonController>/5
        [HttpGet("{p_IdBorne}")]
        public ActionResult<int> Get(int p_IdBorne, string p_typeUtilisateur)
        {
            InferenceTraversePieton inference = this._depot.GetInference(p_IdBorne, p_typeUtilisateur);
            if (inference == null)
            {
                return NotFound();
            }

            return Ok(inference.DureeEnSecondes);
        }

        // POST api/<InferenceTraversePietonController>
        [HttpPost]
        public ActionResult Post([FromBody] InferenceTraversePieton p_inferenceTraversePieton)
        {
            if (p_inferenceTraversePieton == null || !ModelState.IsValid)
            {
                return BadRequest();    
            }

            this._depot.Post(p_inferenceTraversePieton);

            return Created(nameof(this.Post), p_inferenceTraversePieton);
        }
    }
}
