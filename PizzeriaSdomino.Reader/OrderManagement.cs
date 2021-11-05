using PizzeriaSdomino.Repository;
using System.Collections.Generic;

namespace PizzeriaSdomino.Reader
{
    public static class OrderManagement
    {
        //mette insieme tutti i pezzi xD
        public static Scontrino MakeScontrino(IEnumerable<Ordine> ordini) => new(Mapping.Converter(ordini));
    }

}
