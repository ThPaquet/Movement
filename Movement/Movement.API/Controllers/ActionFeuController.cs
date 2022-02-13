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
        private readonly IDepotActionFeu _depotActionFeu;
        private readonly IDepotTypeUtilisateur _depotTypeUtilisateur;
        private readonly IDepotBorne _depotBorne;
        private readonly IDepotUtilisateur _depotUtilisateur;


        public ActionFeuController(IDepotActionFeu p_depotActionFeu, IDepotTypeUtilisateur p_depotTypeUtilisateur, IDepotBorne p_depotBorne, IDepotUtilisateur p_depotUtilisateur)
        {
            this._depotActionFeu = p_depotActionFeu;
            this._depotTypeUtilisateur = p_depotTypeUtilisateur;
            this._depotBorne = p_depotBorne;
            this._depotUtilisateur = p_depotUtilisateur;
        }

        // GET: api/<ActionFeuController>
        [HttpGet]
        public ActionResult<IEnumerable<ActionFeu>> Get()
        {
            return Ok(this._depotActionFeu.GetAll());
        }

        // GET api/<ActionFeuController>/5
        [HttpPost]
        public ActionResult<ActionFeu> Post([FromBody] Requete p_requete)
        {
            Utilisateur user = this._depotUtilisateur.GetAll().Where(user => user.Cle == p_requete.cleUtilisateur).Single();
            TypeUtilisateur typeUser = _depotTypeUtilisateur.GetAll().SingleOrDefault(type => type.Id == user.TypeUtilisateurId);
            ActionFeu action = new ActionFeu();

            if (typeUser.Type == "Standard")
            {

            }
            else if (typeUser.Type == "Maintenance")
            {

            }
            else
            {

                Borne borneDepart = _depotBorne.GetAll().Single(borne => borne.Id == p_requete.IdBorne);
                List<Borne> bornes = _depotBorne.GetBorneByIntersectionId(borneDepart.IntersectionId);
                List<MLModel.ModelInput> modelInputs = new List<MLModel.ModelInput>();
                List<MLModel.ModelOutput> results = new List<MLModel.ModelOutput>();

                foreach (Borne borne in bornes)
                {
                    if (borne.Id != borneDepart.Id)
                    {
                        var sampleData = new MLModel.ModelInput()
                        {
                            TypeUtilisateur = typeUser.Id,
                            Date = DateTime.Now.ToString(),
                            LongitudeBorneDepart = borneDepart.Longitude,
                            LongitudeBorneArrivee = borne.Longitude,
                            LatitudeBorneDepart = borneDepart.Latitude,
                            LatitudeBorneArrivee = borne.Latitude
                        };

                        modelInputs.Add(sampleData);
                    }
                }

                foreach (MLModel.ModelInput modelInput in modelInputs)
                {
                    results.Add(MLModel.Predict(modelInput));
                }

                float average = results.Average(result => result.Score);

                action.Type = $"Pieton {Math.Round(average)}";
            }

            return Ok(action);
        }

        /*// POST api/<ActionFeuController>
        [HttpPost]
        public ActionResult Post([FromBody] ActionFeu p_actionFeu)
        {
            if (p_actionFeu == null || !ModelState.IsValid)
            {
                return BadRequest();
            }

            this._depotActionFeu.Post(p_actionFeu);

            return Created(nameof(this.Post), p_actionFeu);
        }*/

        // PUT api/<ActionFeuController>/5
        [HttpPut("{p_id}")]
        public ActionResult Put(int p_id, [FromBody] ActionFeu p_actionFeu)
        {
            if (p_actionFeu == null || !ModelState.IsValid)
            {
                return BadRequest();
            }

            ActionFeu actionFeu = this._depotActionFeu.GetAll()
                .FirstOrDefault(a => a.Id == p_id);

            if (actionFeu == null)
            {
                return NotFound();
            }

            actionFeu.Type = p_actionFeu.Type;

            this._depotActionFeu.Put(actionFeu);
            return NoContent();
        }
    }
}
