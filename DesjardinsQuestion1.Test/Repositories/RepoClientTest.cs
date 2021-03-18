using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using DesjardinsQuestion1.Context;

namespace DesjardinsQuestion1.Test.Repositories
{
    [TestClass]
    public class RepoClientTest
    {
        private static IDBContext _DBContext;

        public RepoClientTest()
        {
            _DBContext = Substitute.For<IDBContext>();
        }

        [TestMethod]
        public void RepoClient_AjouterClient_RetourneTrue()
        {

        }

        [TestMethod]
        public void RepoClient_AjouterClient_RetourneFalse()
        {

        }

        [TestMethod]
        public void RepoClient_AjouterClient_RetourneException()
        {

        }

        [TestMethod]
        public void RepoClient_AjouterClient_ListClientPasVide()
        {

        }

        [TestMethod]
        public void RepoClient_AjouterClient_ListClientEstVide()
        {

        }
    }
}
