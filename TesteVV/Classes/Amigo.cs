namespace TesteVV.Classes
{
    public class Amigo
    {
        private readonly int _id;
        private string _name;
        private Posicao _posicao;

        public Amigo(int id, string name, Posicao posicao)
        {
            _id = id;
            _name = name;
            _posicao = posicao;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Posicao Posicao
        {
            get { return _posicao; }
        }

        public int Id
        {
            get { return _id; }
        }
    }
}
