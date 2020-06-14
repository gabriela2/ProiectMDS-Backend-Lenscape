using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectMDS.DTOs;
using ProiectMDS.Models;
using ProiectMDS.Repositories.CategorieRepository;

namespace ProiectMDS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategorieController : ControllerBase
    {
        public CategorieController(ICategorieRepository repository)
        {
            ICategorieRepository = repository;
        }

        public ICategorieRepository ICategorieRepository { get; set; }
        // GET: api/Categorie
        [HttpGet]
        public ActionResult <IEnumerable<Categorie>> Get()
        {
            return ICategorieRepository.GetAll();
        }

        // GET: api/Categorie/5
        [HttpGet("{id}")]
        public ActionResult<Categorie> Get(int id)
        {
            return ICategorieRepository.Get(id);
        }

        // POST: api/Categorie
        [HttpPost]
        public Categorie Post(CategorieDTO value)
        {
            Categorie model = new Categorie()
            {
                NumeCategorie = value.NumeCategorie,
                Specificatii = value.Specificatii,
                Descriere = value.Descriere
            };

            return ICategorieRepository.Create(model);
        }

        // PUT: api/Categorie/5
        [HttpPut("{id}")]
        public Categorie Put(int id, CategorieDTO value)
        {
            Categorie model = ICategorieRepository.Get(id);
            if(value.NumeCategorie != null)
            {
                model.NumeCategorie = value.NumeCategorie;
            }

            if (value.Specificatii != null)
            {
                model.Specificatii = value.Specificatii;
            }

            if (value.Descriere != null)
            {
                model.Descriere = value.Descriere;
            }

            return ICategorieRepository.Update(model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public Categorie Delete(int id)
        {
            Categorie model = ICategorieRepository.Get(id);
            return ICategorieRepository.Delete(model);
        }
    }
}
