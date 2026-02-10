using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

//TO DO
//get compatible case
//post Add Case
//get all gpu
//get compatible gpu


namespace PcPartPickerProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildController : ControllerBase
    {
        #region GET requests

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

        [HttpGet]
        [Route("GetAllCpu")]
        public IActionResult GetAllCpu()
        {
            return Ok(DB.cpus);
        }

        [HttpGet]
        [Route("GetAllMobo")]
        public IActionResult GetAllMobo()
        {
            return Ok(DB.motherboards);
        }

        [HttpGet]
        [Route("GetAllCpuCooler")]
        public IActionResult GetAllCpuCooler()
        {
            return Ok(DB.cpuCoolers);
        }

        [HttpGet]
        [Route("GetAllCase")]
        public IActionResult GetAllCase()
        {
            return Ok(DB.cases);
        }

        [HttpGet]
        [Route("{idBuild}/GetCompatibleCpu")]
        public IActionResult GetCompatibleCpu(Guid idBuild)
        {
            Build build = DB.builds.SingleOrDefault(b => b.Id == idBuild);
            if (build is null)
                return BadRequest($"Build with id {idBuild} not found");
            List<Cpu> compatibleCpu = DB.cpus.Where(c => build.IsCompatible(c)).ToList();
            return Ok(compatibleCpu);
        }

        [HttpGet]
        [Route("{idBuild}/GetCompatibleMobo")]
        public IActionResult GetCompatibleMobo(Guid idBuild)
        {
            Build build = DB.builds.SingleOrDefault(b => b.Id == idBuild);
            if (build is null)
                return BadRequest($"Build with id {idBuild} not found");
            List<Motherboard> compatibleMobo = DB.motherboards.Where(m => build.IsCompatible(m)).ToList();
            return Ok(compatibleMobo);
        }

        [HttpGet]
        [Route("{idBuild}/GetCompatibleCpuCooler")]
        public IActionResult GetCompatibleCpuCooler(Guid idBuild)
        {
            Build build = DB.builds.SingleOrDefault(b => b.Id == idBuild);
            if (build is null)
                return BadRequest($"Build with id {idBuild} not found");
            List<CpuCooler> compatibleCpuCooler = DB.cpuCoolers.Where(c => build.IsCompatible(c)).ToList();
            return Ok(compatibleCpuCooler);
        }

        #endregion

        #region POST requests

        [HttpPost]
        [Route("/CreateBuild")]
        public IActionResult CreateBuild()
        {
            Build build = new Build();
            DB.builds.Add(build);
            return Created("", build);
        }

        [HttpPost]
        [Route("{idBuild}/addMobo/{id}")]
        public IActionResult Addmobo(Guid idBuild, Guid id)
        {
            Build build = DB.builds.SingleOrDefault(b => b.Id == idBuild);
            if (build is null)
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

        [HttpPost]
        [Route("{idBuild}/addCpu/{id}")]
        public IActionResult AddCpu(Guid idBuild, Guid id) 
        {
            Build build = DB.builds.SingleOrDefault(b => b.Id == idBuild);
            if (build is null)
                return BadRequest($"Build with id {idBuild} not found");
            Cpu c = DB.cpus.SingleOrDefault(c => c.Id == id);
            if (build.IsCompatible(c))
            {
                build.processor = c;
                Console.WriteLine("Cpu added because is compatible");
                return Created("Cpu added", build);
            }
            else
            {
                Console.WriteLine("errore Cpu non compatibile");
                return BadRequest($"Cpu {id} non compatibile");
            }
        }

        [HttpPost]
        [Route("{idBuild}/addCpuCooler/{id}")]
        public IActionResult AddCpuCooler(Guid idBuild, Guid id)
        {
            Build build = DB.builds.SingleOrDefault(b => b.Id == idBuild);
            if (build is null)
                return BadRequest($"Build with id {idBuild} not found");
            CpuCooler c = DB.cpuCoolers.SingleOrDefault(c => c.Id == id);
            if (build.IsCompatible(c))
            {
                build.cpuCooler = c;
                Console.WriteLine("Cpu added because is compatible");
                return Created("Cpu added", build);
            }
            else
            {
                Console.WriteLine("errore Cpu non compatibile");
                return BadRequest($"Cpu {id} non compatibile");
            }
        }

        #endregion
        
        

    }
}
