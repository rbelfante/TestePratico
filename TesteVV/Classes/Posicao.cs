using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteVV.Classes
{
    public class Posicao
    {
        private readonly int _latitude;
        private readonly int _longitude;

        public Posicao(int latitude, int longitude)
        {
            _latitude = latitude;
            _longitude = longitude;
        }

        public int Latitude
        {
            get { return _latitude; }
        }

        public int Longitude
        {
            get { return _longitude; }
        }
    }
}
