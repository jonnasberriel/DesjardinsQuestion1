using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using DesjardinsQuestion1.Repositories;
using DesjardinsQuestion1.Dependences;
using DesjardinsQuestion1.Fichier;

namespace DesjardinsQuestion1.Test.Etapes
{
    [TestClass]
    public class EtapeFichierTest
    {
        private static IRepoClient _repoClient;
        private static IListClient _listClient;
        private static ILireFichiers _lireFichiers;

        public EtapeFichierTest()
        {
            _repoClient = Substitute.For<IRepoClient>();
            _listClient = Substitute.For<IListClient>();
            _lireFichiers = Substitute.For<ILireFichiers>();
        }

        [TestMethod]
        public void ExecuteEtapeFichier_LectureFichier_RetourneListClient()
        {

        }

        [TestMethod]
        public void ExecuteEtapeFichier_LectureFichier_RetourneListClientVide()
        {

        }

        [TestMethod]
        public void ExecuteEtapeFichier_AjouterClients_AjouteListClient()
        {

        }

        [TestMethod]
        public void ExecuteEtapeFichier_AjouterClients_AjouteListClientVide()
        {

        }
    }
}
