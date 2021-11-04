using System.Collections.Generic;
using System.Linq;

namespace PizzeriaSdomino.Repository
{
    public class Scontrino
    {
        public IList<Pizza> ListaPizze;

        public int IdScontrino;
        
        public decimal Prezzo => ListaPizze.Sum(x => x.Price);

        public Scontrino(IList<Pizza> listapizze)
        {
            ListaPizze = listapizze;
        }
    }

}

