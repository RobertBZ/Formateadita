using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Factory<T> where T : AbstractRegistry, new()
    {
        // Inicializa un metodo get Generico Segun el Modelo
        public T Get()
        {
            return new T();
        }
    }
}
