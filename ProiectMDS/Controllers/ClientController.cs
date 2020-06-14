using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectMDS.DTOs;
using ProiectMDS.Models;
using ProiectMDS.Repositories.ClientRepository;
using ProiectMDS.Repositories.TipClientRepository;
using ProiectMDS.Repositories.ComenziRepository;



namespace ProiectMDS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        public IClientRepository IClientRepository { get; set; }
        public ITipClientRepository ITipClientRepository { get; set; }
        public IComenziRepository IComenziRepository { get; set; }

        public ClientController (IClientRepository clientrepository, ITipClientRepository tipclientrepository, IComenziRepository comenzirepository)
        {
            IClientRepository = clientrepository;
            ITipClientRepository = tipclientrepository;
            IComenziRepository = comenzirepository;
        }
        // GET: api/Client
        [HttpGet]
        public ActionResult<IEnumerable<Client>> Get()
        {
            return IClientRepository.GetAll();
        }

        // GET: api/Client/5
        [HttpGet("{id}")]
        public ClientDetailsDTO Get(int id)
        {
            Client Client = IClientRepository.Get(id);
            ClientDetailsDTO MyClient = new ClientDetailsDTO()
            {
                Nume = Client.Nume,
                DataNasterii = Client.DataNasterii,
                Email = Client.Email,
                Adresa = Client.Adresa,
                TipId = Client.TipId
            };

            IEnumerable<Comenzi> MyComenzi = IComenziRepository.GetAll().Where(x => x.ClientId == Client.Id);
            if(MyComenzi!=null)
            {
                List<float> ComenziSumaList = new List<float>();
                foreach(Comenzi myComanda in MyComenzi)
                {
                    Comenzi comanda = IComenziRepository.GetAll().SingleOrDefault(x => x.Id == myComanda.Id);
                    ComenziSumaList.Add(comanda.SumaTotala);
                }
                MyClient.SumaTotala = ComenziSumaList;
                
            }

            return MyClient;
        }


        // POST: api/Client
        [HttpPost]
        public void Post(ClientDTO value)
        {
            Client model = new Client()
            {
                Nume = value.Nume,
                DataNasterii = value.DataNasterii,
                Email = value.Email,
                Adresa = value.Adresa,
                TipId = value.TipId
            };
            IClientRepository.Create(model);

            for (int i = 0; i < value.ComenziId.Count; i++)
            {
                Comenzi comanda = new Comenzi()
                {
                    ClientId = model.Id,
                    Id = value.ComenziId[i]
                };
                IComenziRepository.Create(comanda);
            }

        }

        // PUT: api/Client/5
        [HttpPut("{id}")]
        public void Put(int id, ClientDTO value)
        {
            Client model = IClientRepository.Get(id);

            if(value.Nume !=null)
            {
                model.Nume = value.Nume;
            }

            if (value.DataNasterii != null)
            {
                model.DataNasterii = value.DataNasterii;
            }

            if (value.Email != null)
            {
                model.Email = value.Email;
            }

            if (value.Adresa != null)
            {
                model.Adresa = value.Adresa;
            }

            if (value.TipId != 0)
            {
                model.TipId = value.TipId;
            }

            IClientRepository.Update(model);

            if (value.ComenziId != null)
            {
                IEnumerable<Comenzi> myComenzi = IComenziRepository.GetAll().Where(x => x.ClientId == id);
                foreach (Comenzi comanda in myComenzi)
                    IComenziRepository.Delete(comanda);
                for(int i=0;i<=value.ComenziId.Count;i++)
                {
                    Comenzi comanda = new Comenzi
                    {
                        ClientId = model.Id,
                        Id = value.ComenziId[i]
                    };
                    IComenziRepository.Create(comanda);
           

                }
            }

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public Client Delete(int id)
        {
            Client model = IClientRepository.Get(id);
            return IClientRepository.Delete(model);
        }
    }
}
