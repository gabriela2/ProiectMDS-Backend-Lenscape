using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectMDS.DTOs;
using ProiectMDS.Models;
using ProiectMDS.Repositories.ComenziRepository;

namespace ProiectMDS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComenziController : ControllerBase
    {
        public ComenziController(IComenziRepository repository)
        {
            IComenziRepository = repository;
        }

        public IComenziRepository IComenziRepository { get; set; }
        // GET: api/Comenzi
        [HttpGet]
        public ActionResult<IEnumerable<Comenzi>> Get()
        {
            return IComenziRepository.GetAll();
        }

        // GET: api/Comenzi/5
        [HttpGet("{id}")]
        public ActionResult<Comenzi> Get(int id)
        {
            return IComenziRepository.Get(id);
        }

        // POST: api/Comenzi
        [HttpPost]
        public Comenzi Post(ComenziDTO value)
        {
            Comenzi model = new Comenzi()
            {
                Id = value.ComenziId,
                MagazinId = value.MagazinId,
                ClientId = value.ClientId,
                SumaTotala = value.SumaTotala
            };

            return IComenziRepository.Create(model);
        }

        // PUT: api/Comenzi/5
        [HttpPut("{id}")]
        public Comenzi Put(int id, ComenziDTO value)
        {
            Comenzi model = IComenziRepository.Get(id);
            if (value.ComenziId != 0)
            {
                model.Id = value.ComenziId;
            }

            if (value.MagazinId != 0)
            {
                model.MagazinId = value.MagazinId;
            }

            if (value.ClientId != 0)
            {
                model.ClientId = value.ClientId;
            }

            if(value.SumaTotala != 0)
            {
                model.SumaTotala = value.SumaTotala;
            }

            return IComenziRepository.Update(model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public Comenzi Delete(int id)
        {
            Comenzi model = IComenziRepository.Get(id);
            return IComenziRepository.Delete(model);
        }
    }
}
