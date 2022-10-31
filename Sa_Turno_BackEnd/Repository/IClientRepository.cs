﻿using Sa_Turno_BackEnd.Entitys;

namespace Sa_Turno_BackEnd.Repository
{
    public interface IClientRepository
    {
        public Client? Get(int id);

        public List<Client> GetAll();

        public void Add(Client client);
    }
}
    