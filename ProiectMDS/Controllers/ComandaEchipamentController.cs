using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectMDS.DTOs;
using ProiectMDS.Models;
using ProiectMDS.Repositories.ComandaEchipamentRepository;

namespace ProiectMDS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComandaEchipamentController : ControllerBase
    {
        public ComandaEchipamentController(IComandaEchipamentRepository repository)
        {
            IComandaEchipamentRepository = repository;
        }

        public IComandaEchipamentRepository IComandaEchipamentRepository { get; set; }
        // GET: api/ComandaEchipament
        [HttpGet]
        public ActionResult<IEnumerable<ComandaEchipament>> Get()
        {
            return IComandaEchipamentRepository.GetAll();
        }

        // GET: api/ComandaEchipament/5
        [HttpGet("{id}")]
        public ActionResult<ComandaEchipament> Get(int id)
        {
            return IComandaEchipamentRepository.Get(id);
        }

        // POST: api/ComandaEchipament
        [HttpPost]
        public ComandaEchipament Post(ComandaEchipamentDTO value)
        {
            ComandaEchipament model = new ComandaEchipament()
            {
                ComenziId = value.ComenziId,
                EchipamentId = value.EchipamentId,
                Cantitate = value.Cantitate
            };

            return IComandaEchipamentRepository.Create(model);
        }

        // PUT: api/ComandaEchipament/5
        [HttpPut("{id}")]
        public ComandaEchipament Put(int id, ComandaEchipamentDTO value)
        {
            ComandaEchipament model = IComandaEchipamentRepository.Get(id);
            if (value.ComenziId != 0)
            {
                model.ComenziId = value.ComenziId;
            }

            if (value.EchipamentId != 0)
            {
                model.EchipamentId = value.EchipamentId;
            }

            if (value.Cantitate != 0)
            {
                model.Cantitate = value.Cantitate;
            }

            return IComandaEchipamentRepository.Update(model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ComandaEchipament Delete(int id)
        {
            ComandaEchipament model = IComandaEchipamentRepository.Get(id);
            return IComandaEchipamentRepository.Delete(model);
        }
    }
}
