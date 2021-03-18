using System;
using DesjardinsQuestion1.Etapes;
using DesjardinsQuestion1.Repositories;
using DesjardinsQuestion1.Context;
using DesjardinsQuestion1.Dependences;
using DesjardinsQuestion1.Fichier;

namespace DesjardinsQuestion1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IDBContext dBContext = new DBContext();
            IRepoClient repoClient = new RepoClient(dBContext);
            IListClient listClient = new ListClient();
            ILireFichiers lireFichiers = new LireFichiers();

            EtapeFichier etapeFichier1 = new EtapeFichier(repoClient, listClient, lireFichiers);
            etapeFichier1.ExecuterEtape();
        }
    }
}
