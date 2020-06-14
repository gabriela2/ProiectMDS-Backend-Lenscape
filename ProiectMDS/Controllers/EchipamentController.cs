using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectMDS.DTOs;
using ProiectMDS.Models;
using ProiectMDS.Repositories.EchipamentRepository;
using ProiectMDS.Repositories.EchipamentCategorieRepository;
using ProiectMDS.Repositories.CategorieRepository;
using ProiectMDS.Repositories.MagazinEchipamentRepository;
using ProiectMDS.Repositories.MagazinRepository;

namespace ProiectMDS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EchipamentController : ControllerBase
    {
        public IEchipamentRepository IEchipamentRepository { get; set; }
        public IEchipamentCategorieRepository IEchipamentCategorieRepository { get; set; }
        public ICategorieRepository ICategorieRepository { get; set; }
        public IMagazinEchipamentRepository IMagazinEchipamentRepository { get; set; }
        public IMagazinRepository IMagazinRepository { get; set; }

        public EchipamentController(IEchipamentRepository echipamentRepository,IEchipamentCategorieRepository echipamentCategorieRepository,ICategorieRepository categorieRepository, IMagazinEchipamentRepository magazinEchipamentRepository,IMagazinRepository magazinRepository)
        {
            IEchipamentRepository = echipamentRepository;
            IEchipamentCategorieRepository = echipamentCategorieRepository;
            ICategorieRepository = categorieRepository;
            IMagazinEchipamentRepository = magazinEchipamentRepository;
            IMagazinRepository = magazinRepository;
        }

        // GET: api/Echipament
        [HttpGet]
        public ActionResult<IEnumerable<Echipament>> Get()
        {
            return IEchipamentRepository.GetAll();
        }

        // GET: api/Echipament/5
        [HttpGet("{id}")]
        public EchipamentDetailsDTO Get(int id)
        {
            Echipament Echipament = IEchipamentRepository.Get(id);
            EchipamentDetailsDTO MyEchipament = new EchipamentDetailsDTO()
            {
                NumeEchipament = Echipament.NumeEchipament,
                Pret = Echipament.Pret,
                Descriere = Echipament.Descriere,
                AnAparitie = Echipament.AnAparitie,
                Specificatii = Echipament.Specificatii,
                ProducatorId = Echipament.ProducatorId,
                img= Echipament.img
         
            };

            IEnumerable<EchipamentCategorie> MyEchipamentCategories = IEchipamentCategorieRepository.GetAll().Where(x => x.EchipamentId == Echipament.Id);
            if(MyEchipamentCategories != null)
            {
                List<string> CategorieNumeList = new List<string>();
                foreach(EchipamentCategorie myechipamentCategorie in MyEchipamentCategories)
                {
                    Categorie myCategorie = ICategorieRepository.GetAll().SingleOrDefault(X => X.Id == myechipamentCategorie.CategorieId);
                    CategorieNumeList.Add(myCategorie.NumeCategorie);
                }
                MyEchipament.NumeCategorie = CategorieNumeList;
            }

            IEnumerable<MagazinEchipament> MyMagazinEchipaments = IMagazinEchipamentRepository.GetAll().Where(x => x.EchipamentId == Echipament.Id);
            if (MyMagazinEchipaments != null)
            {
                List<string> MagazinNumeList = new List<string>();
                foreach (MagazinEchipament mymagazinEchipament in MyMagazinEchipaments)
                {
                    Magazin myMagazin = IMagazinRepository.GetAll().SingleOrDefault(X => X.Id == mymagazinEchipament.MagazinId);
                    MagazinNumeList.Add(myMagazin.Nume);
                }
                MyEchipament.Nume = MagazinNumeList;
            }
            return MyEchipament;

        }


        // POST: api/Echipament
        [HttpPost]
        public void Post(EchipamentDTO value)
        {
            Echipament model = new Echipament()
            {
                NumeEchipament = value.NumeEchipament,
                Pret = value.Pret,
                Descriere = value.Descriere,
                AnAparitie = value.AnAparitie,
                Specificatii = value.Specificatii,
                ProducatorId = value.ProducatorId,
                img=value.img
            };
            IEchipamentRepository.Create(model);

            for(int i = 0; i < value.CategorieId.Count; i++)
            {
                EchipamentCategorie EchipamentCategorie = new EchipamentCategorie()
                {
                    EchipamentId = model.Id,
                    CategorieId = value.CategorieId[i]
                };
                IEchipamentCategorieRepository.Create(EchipamentCategorie);
            }

            for (int i = 0; i < value.MagazinId.Count; i++)
            {
                MagazinEchipament MagazinEchipament = new MagazinEchipament()
                {
                    EchipamentId = model.Id,
                    MagazinId = value.MagazinId[i]
                };
                IMagazinEchipamentRepository.Create(MagazinEchipament);
            }
        }

        // PUT: api/Echipament/5
        [HttpPut("{id}")]
        public void Put(int id, EchipamentDTO value)
        {
            Echipament model = IEchipamentRepository.Get(id);
            if (value.NumeEchipament != null)
            {
                model.NumeEchipament = value.NumeEchipament;
            }

            if (value.Pret != 0)
            {
                model.Pret = value.Pret;
            }

            if (value.Descriere != null)
            {
                model.Descriere = value.Descriere;
            }

            if (value.AnAparitie != 0)
            {
                model.AnAparitie = value.AnAparitie;
            }

            if (value.Specificatii != null)
            {
                model.Specificatii = value.Specificatii;
            }

            if (value.ProducatorId != 0)
            {
                model.ProducatorId = value.ProducatorId;
            }

            if (value.img != null)
            {
                model.img = value.img;
            }

            IEchipamentRepository.Update(model);


            if (value.CategorieId != null)
            {
                IEnumerable<EchipamentCategorie> MyEchipamentCategories = IEchipamentCategorieRepository.GetAll().Where(x => x.EchipamentId == id);
                foreach (EchipamentCategorie myechipamentCategorie in MyEchipamentCategories)
                    IEchipamentCategorieRepository.Delete(myechipamentCategorie);
                for (int i = 0; i < value.CategorieId.Count; i++)
                {
                    EchipamentCategorie EchipamentCategorie = new EchipamentCategorie()
                    {
                        EchipamentId = model.Id,
                        CategorieId = value.CategorieId[i]
                    };
                    IEchipamentCategorieRepository.Create(EchipamentCategorie);
                }
            }

            if (value.MagazinId != null)
            {
                IEnumerable<MagazinEchipament> MyMagazinEchipaments = IMagazinEchipamentRepository.GetAll().Where(x => x.EchipamentId == id);
                foreach (MagazinEchipament MyMagazinEchipament in MyMagazinEchipaments)
                    IMagazinEchipamentRepository.Delete(MyMagazinEchipament);
                for (int i = 0; i < value.MagazinId.Count; i++)
                {
                    MagazinEchipament MagazinEchipament = new MagazinEchipament()
                    {
                        EchipamentId = model.Id,
                        MagazinId = value.MagazinId[i]
                    };
                    IMagazinEchipamentRepository.Create(MagazinEchipament);
                }
            }



        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public Echipament Delete(int id)
        {
            Echipament model = IEchipamentRepository.Get(id);
            return IEchipamentRepository.Delete(model);
        }
    }
}
