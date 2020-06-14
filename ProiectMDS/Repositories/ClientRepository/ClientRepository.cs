using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Contexts;
using ProiectMDS.Models;

namespace ProiectMDS.Repositories.ClientRepository
{
    public class ClientRepository:IClientRepository
    {
        public Context _context { get; set; }
        
        public ClientRepository(Context context)
        {
            _context = context;
        }

        public Client Create(Client client)
        {
            var result = _context.Add<Client>(client);
            _context.SaveChanges();
            return result.Entity;
        }

        public Client Get(int Id)
        {
            return _context.Client.SingleOrDefault(x => x.Id == Id);
        }

        public List<Client> GetAll()
        {
            return _context.Client.ToList();
        }

        public Client Update(Client Client)
        {
            _context.Entry(Client).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Client;
        }

        public Client Delete(Client Client)
        {
            var result = _context.Remove(Client);
            _context.SaveChanges();
            return result.Entity;
        }

    }
}
