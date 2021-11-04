namespace PizzeriaSdomino.Repository
{
    public class Normale : Impasto
    {
        public override string Nome { get => this.GetType().Name; set => throw new System.NotImplementedException(); }
        public override decimal Prezzo { get => 0; set => throw new System.NotImplementedException(); }
    }


}

