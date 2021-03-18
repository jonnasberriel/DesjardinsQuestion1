using System.Collections.Generic;
using DesjardinsQuestion1.Entites;

namespace DesjardinsQuestion1.Repositories
{
    public interface IRepoClient
    {
        void AjouterClient(IEnumerable<Client> clients);
        bool AjouterClient(Client client);
    }
}
