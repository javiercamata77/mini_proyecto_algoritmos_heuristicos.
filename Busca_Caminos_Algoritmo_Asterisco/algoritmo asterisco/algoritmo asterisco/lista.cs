using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algoritmo_asterisco
{
    //clase para añadir los elementos
    public class lista
    {
        //variables de tipo nodo que nos ayuda a identificar el inicio y fin
        public Nodo inicio, fin;
        //crear el constructor
        public lista()
        {
            inicio = null;
            fin = null;
        }
        public void agregarelemntos(String[] elemento)
        {
            inicio = new Nodo(elemento, inicio);
            if(fin==null)
            {
                fin = inicio;
            }
        }

        public void mostrarelementos()
        {
            Nodo recorrer = inicio;
            while (recorrer != null)
            {
                for (int i = 0; i < recorrer.dato.Length; i++)
                    //MessageBox.Show("lista cerrada [ " + i + " ] = " + recorrer.dato[i] + "]");
                recorrer = recorrer.enlace;
            }

        }


        public String[] buscarlista(String elemento)
        {
            String[] datos = new String[4];
            Nodo recorrer = inicio;
            while (recorrer != null)
            {
                if (recorrer.dato[0] == elemento)
                {
                    return recorrer.dato;
                }
                recorrer = recorrer.enlace;
            }
            datos[0] = null;
            return datos;
        }
       /* public bool buscarlista(String[] elemento)
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
        }*/

    }
}
