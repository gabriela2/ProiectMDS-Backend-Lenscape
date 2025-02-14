﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;

namespace ProiectMDS.Repositories.ClientRepository
{
    public interface IClientRepository
    {
        List<Client> GetAll();
        Client Get(int Id);
        Client Create(Client Client);
        Client Update(Client Client);
        Client Delete(Client Client);
    }
}
