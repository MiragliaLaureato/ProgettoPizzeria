using System;
using System.Collections.Generic;

namespace PizzeriaSdomino.Reader
{
    public interface IReader<T>
    {
        IEnumerable<T> GetCollection();
    }

}
