using System;

namespace PizzeriaSdomino.Repository
{
    public class FactoryComponent
    {
        public static IComponent Build(string nome) => nome switch
        {

            "Margherita" => new Margherita(),
            "Pepperoni" => new Pepperoni(),
            "Napoletana" => new Napoletana(),

            "Normale" => new Normale(),
            "Integrale" => new Integrale(),

            "Cotto" => new Cotto(),
            "Crudo" => new Crudo(),
            "Funghi" => new Funghi(),
            "Ananas" => new Ananas(),
            _ => throw new NotImplementedException()
        };
    }

}

