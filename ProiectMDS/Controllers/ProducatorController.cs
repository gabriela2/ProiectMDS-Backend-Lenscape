using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectMDS.DTOs;
using ProiectMDS.Models;
using ProiectMDS.Repositories.ProducatorRepository;

namespace ProiectMDS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProducatorController : ControllerBase
    {
        public ProducatorController(IProducatorRepository repository)
        {
            IProducatorRepository = repository;
        }

        public IProducatorRepository IProducatorRepository { get; set; }
        // GET: api/Producator
        [HttpGet]
        public ActionResult<IEnumerable<Producator>> Get()
        {
            return IProducatorRepository.GetAll();
        }

        // GET: api/Producator/5
        [HttpGet("{id}")]
        public ActionResult<Producator> Get(int id)
        {
            return IProducatorRepository.Get(id);
        }

        // POST: api/Producator
        [HttpPost]
        public Producator Post(ProducatorDTO value)
        {
            Producator model = new Producator()
            {
                NumeProducator = value.NumeProducator,
                TaraOrigine = value.TaraOrigine
            };

            return IProducatorRepository.Create(model);
        }

        // PUT: api/Producator/5
        [HttpPut("{id}")]
        public Producator Put(int id, ProducatorDTO value)
        {
            Producator model = IProducatorRepository.Get(id);
            if (value.NumeProducator != null)
            {
                model.NumeProducator = value.NumeProducator;
            }

            if (value.TaraOrigine != null)
            {
                model.TaraOrigine = value.TaraOrigine;
            }

            return IProducatorRepository.Update(model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public Producator Delete(int id)
        {
            Producator model = IProducatorRepository.Get(id);
            return IProducatorRepository.Delete(model);
        }
    }
}
