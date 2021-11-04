using System;

namespace PizzeriaSdomino.Repository
{
    public class Margherita : BasePizza
    {
        public override string Nome { get => this.GetType().Name; set => throw new NotImplementedException(); }
        
        public override decimal Prezzo { get => 5; set => throw new NotImplementedException(); }
    }

}

