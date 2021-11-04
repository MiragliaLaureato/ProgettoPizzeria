using CsvHelper;
using PizzeriaSdomino.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using System.Globalization;

namespace PizzeriaSdomino.Reader
{
    public class CsvLettore : IReader<Pizza>
    {
        private CsvHelper.CsvDataReader Helper;
        public CsvLettore(CsvHelper.CsvDataReader helper)
        {
            Helper = helper;
        }

        public IEnumerable<Scontrino> GetCollection()
        {
            var directory = new DirectoryInfo(@"C:\\*.csv");
            var allFiles = directory.GetFiles();

            List<Scontrino> tuttiEvasori = new List<Scontrino>();

            foreach (var tmp in allFiles)
            {
                using var reader = new StreamReader(tmp.FullName);
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = false,
                    Delimiter = ";"
                };

                using var csvReader = new CsvReader(reader, config) { };
                csvReader.Context.RegisterClassMap<OrdineClassMap>();
                var ordini = csvReader.GetRecords<Ordine>();


                Scontrino sc = new Scontrino(null);


                foreach (var pizz in ordini)
                {
                    var basepizza = FactoryComponent.Build(pizz.BasePizza);
                    var impasto = FactoryComponent.Build(pizz.Impasto);
                    var ingredienti = pizz.ListaIngredienti;
                    var listaSplit = ingredienti.Split(",");
                    List<IComponent> listaingredienti = new List<IComponent>();
                    
                    foreach (var ing in listaSplit)
                    {
                        listaingredienti.Add(FactoryComponent.Build(ing));
                    }

                    var pizza = new Pizza(basepizza, impasto, listaingredienti);
                    sc.ListaPizze.Add(pizza);
                }

                tuttiEvasori.Add(sc);

            }
            return tuttiEvasori;
        }

        }
}
