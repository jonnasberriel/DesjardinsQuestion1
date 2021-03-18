using System.Collections.Generic;
using DesjardinsQuestion1.Entites;

namespace DesjardinsQuestion1.Fichier
{
    public interface ILireFichiers
    {
        IEnumerable<Client> LireFichier(string nomFichier);
    }
}
