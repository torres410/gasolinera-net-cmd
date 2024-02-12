using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GASOLINERA2
{
    class cFila
    {
        cNodo ancla;

        cNodo trabajo;

        public cFila()
        {
            ancla = new cNodo();

            ancla.Siguiente = null;
        }

        public void transversa()
        {
            trabajo = ancla;

            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;

                string d = trabajo.Dato;
                Console.Write(" {0} |", d);
            }
            Console.WriteLine();
        }

        public void Encolar(string pDato)
        {
            trabajo = ancla;

            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
            }

            cNodo temp = new cNodo();

            temp.Dato = pDato;

            temp.Siguiente = null;

            trabajo.Siguiente = temp;
        }

        public string Desencolar()
        {
            string valor = "";

            if (ancla.Siguiente != null)
            {
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;

                ancla.Siguiente = trabajo.Siguiente;
                trabajo.Siguiente = null;
            }
            return valor;
        }

        public string Peek()
        {
            string valor = "";

            if (ancla.Siguiente != null)
            {
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;
            }
            return valor;
        }

        public bool BuscarCliente(string nom)
        {
            trabajo = ancla;
            
            while (trabajo != null)
            {
                if (trabajo.Dato == nom)
                {
                    return true;
                }
                trabajo = trabajo.Siguiente;
            }
            return false;
        }
    }
}
