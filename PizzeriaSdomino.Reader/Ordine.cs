using CsvHelper.Configuration;

namespace PizzeriaSdomino.Reader
{
    public class Ordine
    {
        public string BasePizza;
        public string Impasto;
        public string ListaIngredienti;
    }

    public sealed class OrdineClassMap : ClassMap<Ordine>
    {
        public OrdineClassMap()
        {
            Map(m => m.BasePizza);
            Map(m => m.Impasto);
            Map(m => m.ListaIngredienti);
        }
    }
}