using System;
using System.Collections.Generic;
using System.Text;
using DesjardinsQuestion1.Entites;

namespace DesjardinsQuestion1.Dependences
{
    public interface IListClient
    {
        public IEnumerable<Client> Clients { get; set; }
    }
}
