using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using System.Globalization;

namespace PizzeriaSdomino.Reader
{
    public class CsvLettore : IReader<Ordine>
    {
        public IEnumerable<Ordine> GetCollection(string fileName)
        {
            using var reader = new StreamReader(fileName);
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
                Delimiter = ";"
            };

            using var csvReader = new CsvReader(reader, config) { };
            csvReader.Context.RegisterClassMap<OrdineClassMap>();
            return csvReader.GetRecords<Ordine>();
        }
    }

}
