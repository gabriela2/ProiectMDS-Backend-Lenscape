using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectMDS.DTOs;
using ProiectMDS.Models;
using ProiectMDS.Repositories.MagazinEchipamentRepository;

namespace ProiectMDS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MagazinEchipamentController : ControllerBase
    {
        public MagazinEchipamentController(IMagazinEchipamentRepository repository)
        {
            IMagazinEchipamentRepository = repository;
        }

        public IMagazinEchipamentRepository IMagazinEchipamentRepository { get; set; }
        // GET: api/MagazinEchipament
        [HttpGet]
        public ActionResult<IEnumerable<MagazinEchipament>> Get()
        {
            return IMagazinEchipamentRepository.GetAll();
        }

        // GET: api/MagazinEchipament/5
        [HttpGet("{id}")]
        public ActionResult<MagazinEchipament> Get(int id)
        {
            return IMagazinEchipamentRepository.Get(id);
        }

        // POST: api/MagazinEchipament
        [HttpPost]
        public MagazinEchipament Post(MagazinEchipamentDTO value)
        {
            MagazinEchipament model = new MagazinEchipament()
            {
                MagazinId = value.MagazinId,
                EchipamentId = value.EchipamentId,
                Stoc = value.Stoc
            };

            return IMagazinEchipamentRepository.Create(model);
        }

        // PUT: api/MagazinEchipament/5
        [HttpPut("{id}")]
        public MagazinEchipament Put(int id, MagazinEchipamentDTO value)
        {
            MagazinEchipament model = IMagazinEchipamentRepository.Get(id);
            if (value.MagazinId != 0)
            {
                model.MagazinId = value.MagazinId;
            }

            if (value.EchipamentId != 0)
            {
                model.EchipamentId = value.EchipamentId;
            }

            if(value.Stoc != 0)
            {
                model.Stoc = value.Stoc;
            }

            return IMagazinEchipamentRepository.Update(model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public MagazinEchipament Delete(int id)
        {
            MagazinEchipament model = IMagazinEchipamentRepository.Get(id);
            return IMagazinEchipamentRepository.Delete(model);
        }
    }
}
