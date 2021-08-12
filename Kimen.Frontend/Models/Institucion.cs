using System;
namespace Kimen.Frontend.Models
{
    public class Institucion
    {
        public string Nombre { get; set; }

        public Institucion(string name)
        {
            Nombre = name;
        }
    }
}
