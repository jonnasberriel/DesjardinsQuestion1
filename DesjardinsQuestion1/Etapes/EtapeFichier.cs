using System;
using DesjardinsQuestion1.Repositories;
using DesjardinsQuestion1.Dependences;
using DesjardinsQuestion1.Fichier;

namespace DesjardinsQuestion1.Etapes
{
    public class EtapeFichier : Etape
    {
        private readonly IRepoClient _repoClient;
        private readonly IListClient _listClient;
        private readonly ILireFichiers _lireFichiers; 

        public EtapeFichier(IRepoClient repoClient, IListClient listClient, ILireFichiers lireFichiers)
        {
            _repoClient = repoClient;
            _listClient = listClient;
            _lireFichiers = lireFichiers;
        }

        public override void ExecuterEtape()
        {
            try
            {
                //Ajouter le nom du fichier dans un resource, ou dans un web.config, etc
                //Fichier1
                var nomFichier = "";
                LectureFichier(nomFichier);
                
                //Fichier2
                nomFichier = "";
                LectureFichier(nomFichier);
                
                //Fichier3
                nomFichier = "";
                LectureFichier(nomFichier);

                //Sauvegarder les données après la lecture de tous les fichiers
                //ou èa chaque lecture: Vérifier les règles
                AjouterClients();
            }
            catch (Exception ex)
            {
                //LOG
                throw ex;
            }
        }

        protected override void LectureFichier(string nomFichier)
        {
           
            _listClient.Clients = _lireFichiers.LireFichier(nomFichier);
        }

        protected override void AjouterClients()
        {
            _repoClient.AjouterClient(_listClient.Clients);
        }
    }
}
