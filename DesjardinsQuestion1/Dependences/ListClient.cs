using System.Collections.Generic;
using DesjardinsQuestion1.Entites;

namespace DesjardinsQuestion1.Dependences
{
    public class ListClient : IListClient
    {
        public IEnumerable<Client> Clients { get; set; } = new List<Client>();
    }
}
