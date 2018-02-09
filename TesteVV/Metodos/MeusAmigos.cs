using System.Collections.Generic;
using TesteVV.Classes;
using System.Linq;
using System;

namespace TesteVV.Metodos
{
    public class MeusAmigos
    {
        private List<Amigo> _amigos;
        private Amigo _amigoVisitado;

        public MeusAmigos(List<Amigo> amigos)
        {
            _amigos = amigos;
        }

        public Amigo GetAmigoVisitado(string nomeAmigo)
        {
            _amigoVisitado = _amigos.FirstOrDefault(x => x.Name == nomeAmigo);

            return _amigoVisitado;
        }

        public List<Amigo> GetAmigosProximos(Amigo amigoVisitado)
        {
            return CalcularDistancia(amigoVisitado.Posicao).OrderBy(x => x.Value).Take(3)
                .Select(_item => _amigos.ElementAt(_item.Key)).ToList();
        }

        private Dictionary<int, double> CalcularDistancia(Posicao posicaoAtual)
        {
            var distanciasDosMeusAmigos = new Dictionary<int, double>();

            _amigos.ForEach(x =>
            {
                if (x != _amigoVisitado)
                {
                    var latitude = Math.Pow((x.Posicao.Latitude - _amigoVisitado.Posicao.Latitude), 2);
                    var longitude = Math.Pow((x.Posicao.Longitude - _amigoVisitado.Posicao.Longitude), 2);
                    var distanciaCalculada = Math.Sqrt(latitude + longitude);

                    distanciasDosMeusAmigos.Add(x.Id, distanciaCalculada);
                }
            });

            return distanciasDosMeusAmigos;
        }
        
        public static List<Amigo> CreateFriendsList()
        {
            return new List<Amigo>
            {
                new Amigo(0, "Camila", new Posicao(25, 20)),
                new Amigo(1, "João", new Posicao(44, 33)),
                new Amigo(2, "André", new Posicao(133, 100)),
                new Amigo(3, "Fred", new Posicao(120, 45)),
                new Amigo(4, "Carlos", new Posicao(77, 33)),
                new Amigo(5, "Felipe", new Posicao(10, 98)),
                new Amigo(6, "Rafaela", new Posicao(13, 5)),
                new Amigo(7, "Bigo", new Posicao(55, 35)),
                new Amigo(8, "Jarbas", new Posicao(98, 69)),
                new Amigo(9, "Wesley", new Posicao(150, 88))
            };
        }
    }
}
