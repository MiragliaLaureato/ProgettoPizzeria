using System;

namespace PizzeriaSdomino.Repository
{
    public class Pepperoni : BasePizza
    {
        public override string Nome { get => this.GetType().Name; set => throw new NotImplementedException(); }
        public override decimal Prezzo { get => 7; set => throw new NotImplementedException(); }
    }

}

