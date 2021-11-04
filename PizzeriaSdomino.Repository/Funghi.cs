namespace PizzeriaSdomino.Repository
{
    public class Funghi : Ingredient
    {
        public override string Nome { get => this.GetType().Name; set => throw new System.NotImplementedException(); }
        public override decimal Prezzo { get => 2; set => throw new System.NotImplementedException(); }
    }
}

