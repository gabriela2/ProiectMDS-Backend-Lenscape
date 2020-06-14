using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectMDS.DTOs;
using ProiectMDS.Models;
using ProiectMDS.Repositories.TipClientRepository;

namespace ProiectMDS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipClientController : ControllerBase
    {
        public TipClientController(ITipClientRepository repository)
        {
            ITipClientRepository = repository;
        }

        public ITipClientRepository ITipClientRepository { get; set; }
        // GET: api/TipClient
        [HttpGet]
        public ActionResult<IEnumerable<TipClient>> Get()
        {
            return ITipClientRepository.GetAll();
        }

        // GET: api/TipClient/5
        [HttpGet("{id}")]
        public ActionResult<TipClient> Get(int id)
        {
            return ITipClientRepository.Get(id);
        }

        // POST: api/TipClient
        [HttpPost]
        public TipClient Post(TipClientDTO value)
        {
            TipClient model = new TipClient()
            {
                Descriere = value.Descriere,
                Discount = value.Discount
            };

            return ITipClientRepository.Create(model);
        }

        // PUT: api/TipClient/5
        [HttpPut("{id}")]
        public TipClient Put(int id, TipClientDTO value)
        {
            TipClient model = ITipClientRepository.Get(id);
            if (value.Descriere != null)
            {
                model.Descriere = value.Descriere;
            }

            if (value.Discount != 0)
            {
                model.Discount = value.Discount;
            }

            return ITipClientRepository.Update(model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public TipClient Delete(int id)
        {
            TipClient model = ITipClientRepository.Get(id);
            return ITipClientRepository.Delete(model);
        }
    }
}
