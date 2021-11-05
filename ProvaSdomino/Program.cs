using PizzeriaSdomino.Reader;
using System;
using System.Linq;

namespace ProvaSdomino
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Execute();
        }
        public static void Execute()
        {
            var listaPath = FolderReader.GetAllFilePath(@"ordini");
            var csvLettore = new CsvLettore();
            foreach (var tmp in listaPath)
            {
                var ordini = csvLettore.GetCollection(tmp);
                var scontrino = OrderManagement.MakeScontrino(ordini.ToList());
                Console.WriteLine(scontrino.ToString());
            }
            Console.Read();
        }
    }
}
