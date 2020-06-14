using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectMDS.DTOs;
using ProiectMDS.Models;
using ProiectMDS.Repositories.MagazinRepository;

namespace ProiectMDS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MagazinController : ControllerBase
    {
        public MagazinController(IMagazinRepository repository)
        {
            IMagazinRepository = repository;
        }

        public IMagazinRepository IMagazinRepository { get; set; }
        // GET: api/Magazin
        [HttpGet]
        public ActionResult<IEnumerable<Magazin>> Get()
        {
            return IMagazinRepository.GetAll();
        }

        // GET: api/Magazin/5
        [HttpGet("{id}")]
        public ActionResult<Magazin> Get(int id)
        {
            return IMagazinRepository.Get(id);
        }

        // POST: api/Magazin
        [HttpPost]
        public Magazin Post(MagazinDTO value)
        {
            Magazin model = new Magazin()
            {
                Nume = value.Nume,
                Adresa = value.Adresa
            };

            return IMagazinRepository.Create(model);
        }

        // PUT: api/Magazin/5
        [HttpPut("{id}")]
        public Magazin Put(int id, MagazinDTO value)
        {
            Magazin model = IMagazinRepository.Get(id);
            if (value.Nume != null)
            {
                model.Nume = value.Nume;
            }

            if (value.Adresa != null)
            {
                model.Adresa = value.Adresa;
            }

            return IMagazinRepository.Update(model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public Magazin Delete(int id)
        {
            Magazin model = IMagazinRepository.Get(id);
            return IMagazinRepository.Delete(model);
        }
    }
}
