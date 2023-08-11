using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_cliente
{
    internal class Client
    {
        //Se crea intrincicamente las propiedades y los metodos get y set
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Telefono { get; set; }

        public string Addres { get; set; }

        public string NameLastName { get { return $"{Name} {LastName}"; } }

        override
        public string ToString()
        {
            return NameLastName;
        }
    }
}
