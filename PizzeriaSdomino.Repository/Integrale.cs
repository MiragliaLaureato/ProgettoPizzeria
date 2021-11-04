namespace PizzeriaSdomino.Repository
{
    public class Integrale : Impasto
    {
        public override string Nome { get => this.GetType().Name; set => throw new System.NotImplementedException(); }
        public override decimal Prezzo { get => 1; set => throw new System.NotImplementedException(); }
    }


}

