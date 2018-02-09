using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteVV.Classes;
using TesteVV.Metodos;

namespace TesteAmigos
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TesteTop3Amigos()
        {
            var nomeAmigo = "Wesley";
            var listaAmigos = MeusAmigos.CreateFriendsList();
            var amigosMetodos = new MeusAmigos(listaAmigos);

            var top3 = amigosMetodos.GetAmigosProximos(amigosMetodos.GetAmigoVisitado(nomeAmigo));

            Assert.AreEqual(3, top3.Count);
        }

        [TestMethod]
        public void TesteAmigoInvalido()
        {
            var nomeAmigo = "José";
            var listaAmigos = MeusAmigos.CreateFriendsList();
            var amigosMetodos = new MeusAmigos(listaAmigos);

            var amigoInexistente = amigosMetodos.GetAmigoVisitado(nomeAmigo);

            Assert.IsNull(amigoInexistente);
        }
    }
}
