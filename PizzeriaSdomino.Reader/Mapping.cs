using PizzeriaSdomino.Repository;
using System.Collections.Generic;
using System.Linq;

namespace PizzeriaSdomino.Reader
{

    public static class Mapping
    {
        public static IEnumerable<Pizza> Converter(IEnumerable<Ordine> listaordini)
        {

            foreach (var pizz in listaordini)
            {
                var basepizza = FactoryComponent.Build(pizz.BasePizza);
                var impasto = FactoryComponent.Build(pizz.Impasto);
                var ingredienti = pizz.ListaIngredienti;
                var listaSplit = ingredienti.Split(",");
                List<IComponent> listaingredienti = new List<IComponent>();

                listaingredienti.AddRange(listaSplit.Select(x => FactoryComponent.Build(x)));

                var pizza = new Pizza(basepizza, impasto, listaingredienti);
                yield return pizza;
            }
        }
    }

}
