using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GASOLINERA2
{
    class cNodo
    {
        
        private string dato;

        private cNodo siguiente = null;

        public string Dato { get => dato; set => dato = value; }

        internal cNodo Siguiente { get => siguiente; set => siguiente = value; }

        public override string ToString()
        {
            return string.Format("[{0}]", dato);
        }
    }
}
