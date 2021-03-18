using System.Collections.Generic;
using DesjardinsQuestion1.Entites;
using DesjardinsQuestion1.Context;

namespace DesjardinsQuestion1.Repositories
{
    public class RepoClient : IRepoClient
    {
        private readonly IDBContext _DBContext;

        public RepoClient(IDBContext DBContext)
        {
            _DBContext = DBContext;
        }

        public void AjouterClient(IEnumerable<Client> clients)
        {
            foreach (var client in clients)
            {
                AjouterClient(client);
            }
        }

        public bool AjouterClient(Client client)
        {
            return true;

            //Ajouter les données du client dans la BD.
            //Il faut faire le mapping du objet vers la "table". On peut utiliser AutoMapper
            //_DBContext.client.Add(c);
            //_DBContext.SaveChanges();

            //return c.ID;
        }
    }
}
