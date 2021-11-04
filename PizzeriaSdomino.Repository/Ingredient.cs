namespace PizzeriaSdomino.Repository
{
    public abstract class Ingredient : IComponent
    {
        public abstract string Nome { get; set; }
        public abstract decimal Prezzo { get; set; }
    }
}

