namespace DesjardinsQuestion1.Etapes
{
    public abstract class Etape
    {
        public abstract void ExecuterEtape();

        protected abstract void LectureFichier(string nomFichier);

        protected abstract void AjouterClients();
    }
}
