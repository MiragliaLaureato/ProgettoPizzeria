using System.Collections.Generic;
using System.Linq;

namespace PizzeriaSdomino.Repository
{
    public class Pizza
    {
        public BasePizza BasePizza;
        public Impasto Impasto;
        public List<Ingredient> Ingredienti;
        public decimal Price => Ingredienti.Any(i=> i.Nome == "Ananas") ? 0 : BasePizza.Prezzo + Impasto.Prezzo + Ingredienti.Sum(x => x.Prezzo);
         
        public Pizza(BasePizza basepizza, Impasto impasto ,List<Ingredient > listaingredienti)
        {
            BasePizza = basepizza;
            Impasto = impasto;
            Ingredienti = listaingredienti;
        }
    }

}

