using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace PcPartPickerProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildController : ControllerBase
    {
        [HttpGet]
        // api/....
        public IActionResult GetAll()
        {
            return Ok(DB.builds);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(Guid id)
        {
            // find build by id
            var build = DB.builds.Find(b => b.Id == id);
            return build != null ? Ok(build) : BadRequest($"id {id} not found");
        }

        [HttpPost]
        public IActionResult CreateBuild()
        {
            Build build = new Build();
            //build.Id = Guid.NewGuid();
            DB.builds.Add(build);
            return Created("", build);
        }

        [HttpPost]
        [Route("addMobo/{id}")]
        public IActionResult Addmobo(Guid idBuild, Guid id)
        {
            Build build = DB.builds.SingleOrDefault(b => b.Id == idBuild);
            if(build is null)
                return BadRequest($"Build with id {idBuild} not found");
            Motherboard m = DB.motherboards.SingleOrDefault(m => m.Id == id);
            if (build.IsCompatible(m))
            {
                build.motherboard = m;
                Console.WriteLine("motherboard added because is compatible");
                return Created("motherboard added", build);
            }
            else
            {
                Console.WriteLine("errore Motherboard non compatibile");
                return BadRequest($"motherboard {id} non compatibile");
            }
        }
    }
}
