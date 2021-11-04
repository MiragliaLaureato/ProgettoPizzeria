using System;

namespace PizzeriaSdomino.Repository
{
    public class Napoletana : BasePizza
    {
        public override string Nome { get => this.GetType().Name ; set => throw new NotImplementedException(); }
        public override decimal Prezzo { get => 3; set => throw new NotImplementedException(); }
    }

}

