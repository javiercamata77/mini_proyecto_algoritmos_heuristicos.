using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algoritmo_asterisco
{
    class claseauxiliar
    {
        //variables de tipo nodo que nos ayuda a identificar el inicio y fin
        public Nodo inicio, fin;
        //crear el constructor
        public claseauxiliar()
        {
            inicio = null;
            fin = null;
        }
        public void agregarelemntos(String[] elemento)
        {
            inicio = new Nodo(elemento, inicio);
            if (fin == null)
            {
                fin = inicio;
            }
        }

        public void mostrarelementos()
        {
            Nodo recorrer = inicio;
            while (recorrer != null)
            {
                MessageBox.Show(" lista Cerrada" + recorrer.dato + ",");
                recorrer = recorrer.enlace;
            }

        }
        public bool buscarlista(String[] elemento)
        {
            Nodo recorrer = inicio;
            while (recorrer != null)
            {
                if (recorrer.dato == elemento)
                {
                    return true;
                }
                recorrer = recorrer.enlace;
            }
            return false;
        }
    }
}
