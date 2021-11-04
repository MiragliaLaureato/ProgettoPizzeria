using System.Collections.Generic;
using System.Linq;

namespace PizzeriaSdomino.Repository
{
    public class Pizza
    {
        public IComponent BasePizza;
        public IComponent Impasto;
        public List<IComponent> Ingredienti;
        public decimal Price => Ingredienti.Any(i=> i.Nome == "Ananas") ? 0 : BasePizza.Prezzo + Impasto.Prezzo + Ingredienti.Sum(x => x.Prezzo);
         
        public Pizza(IComponent basepizza, IComponent impasto ,List<IComponent> listaingredienti)
        {
            BasePizza = basepizza;
            Impasto = impasto;
            Ingredienti = listaingredienti;
        }
    }

}

