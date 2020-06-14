using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectMDS.DTOs;
using ProiectMDS.Models;
using ProiectMDS.Repositories.EchipamentCategorieRepository;

namespace ProiectMDS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EchipamentCategorieController : ControllerBase
    {
        public EchipamentCategorieController(IEchipamentCategorieRepository repository)
        {
            IEchipamentCategorieRepository = repository;
        }

        public IEchipamentCategorieRepository IEchipamentCategorieRepository { get; set; }
        // GET: api/EchipamentCategorie
        [HttpGet]
        public ActionResult<IEnumerable<EchipamentCategorie>> Get()
        {
            return IEchipamentCategorieRepository.GetAll();
        }

        // GET: api/EchipamentCategorie/5
        [HttpGet("{id}")]
        public ActionResult<EchipamentCategorie> Get(int id)
        {
            return IEchipamentCategorieRepository.Get(id);
        }

        // POST: api/EchipamentCategorie
        [HttpPost]
        public EchipamentCategorie Post(EchipamentCategorieDTO value)
        {
            EchipamentCategorie model = new EchipamentCategorie()
            {
                EchipamentId = value.EchipamentId,
                CategorieId = value.CategorieId
            };

            return IEchipamentCategorieRepository.Create(model);
        }

        // PUT: api/EchipamentCategorie/5
        [HttpPut("{id}")]
        public EchipamentCategorie Put(int id, EchipamentCategorieDTO value)
        {
            EchipamentCategorie model = IEchipamentCategorieRepository.Get(id);
            if (value.EchipamentId != 0)
            {
                model.EchipamentId = value.EchipamentId;
            }

            if (value.CategorieId != 0)
            {
                model.CategorieId = value.CategorieId;
            }

            return IEchipamentCategorieRepository.Update(model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public EchipamentCategorie Delete(int id)
        {
            EchipamentCategorie model = IEchipamentCategorieRepository.Get(id);
            return IEchipamentCategorieRepository.Delete(model);
        }
    }
}
