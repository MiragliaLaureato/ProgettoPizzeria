namespace PizzeriaSdomino.Repository
{
    public abstract class Impasto : IComponent
    {
        public abstract string Nome { get; set; }
        public abstract decimal Prezzo { get; set; }
    }


}

