using System;
using TesteVV.Metodos;

namespace TesteVV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sua lista de amigos \n");

            var listaAmigos = MeusAmigos.CreateFriendsList();

            var meusAmigos = new MeusAmigos(listaAmigos);

            Console.WriteLine("Lista de amigos: \n");

            foreach (var amigo in listaAmigos)
            {
                Console.WriteLine("Nome: {0} | Latitude: {1} | Longitude: {2}", amigo.Name, amigo.Posicao.Latitude, amigo.Posicao.Longitude);
            }

            Console.WriteLine("Digite o amigo que está sendo visitado: ");

            var amigoVisitado = meusAmigos.GetAmigoVisitado(Console.ReadLine());

            if (amigoVisitado == null)
                Console.WriteLine("Este nome não está na lista dos seus amigos. \n");
            else
            {
                var amigosProximos = meusAmigos.GetAmigosProximos(amigoVisitado);

                Console.WriteLine("Lista de amigos próximos:");

                foreach (var item in amigosProximos)
                {
                    Console.WriteLine("Amigo: {0}", item.Name);
                }
            }

            Console.ReadKey();
        }
    }
}
