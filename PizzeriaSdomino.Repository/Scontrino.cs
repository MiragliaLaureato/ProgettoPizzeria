using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzeriaSdomino.Repository
{
    public class Scontrino
    {
        public IEnumerable<Pizza> ListaPizze;

        public int IdScontrino;
        
        public decimal Prezzo => ListaPizze.Sum(x => x.Price);

        public Scontrino(IEnumerable<Pizza> listapizze)
        {
            ListaPizze = listapizze;
        }
        public override string ToString()
        {
            return string.Concat(ListaPizze.Select(x => x.ToString())+Environment.NewLine);
        }
    }

}

