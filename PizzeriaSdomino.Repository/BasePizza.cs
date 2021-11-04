namespace PizzeriaSdomino.Repository
{
    public abstract class BasePizza : IComponent
    {
        public abstract string Nome { get; set; }
        public abstract decimal Prezzo { get; set; }
    }

}

