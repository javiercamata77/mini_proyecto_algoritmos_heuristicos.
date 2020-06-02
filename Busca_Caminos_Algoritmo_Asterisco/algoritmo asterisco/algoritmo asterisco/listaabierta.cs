using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algoritmo_asterisco
{
   public class listaabierta
    {
        //variables de tipo nodo que nos ayuda a identificar el inicio y fin
        public Nodo inicio, fin;
       
        //crear el constructor
        public listaabierta()
        {
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
                for(int i =0; i<recorrer.dato.Length;i++)
               MessageBox.Show("lista abierta [ " + i +" ] = " + recorrer.dato[i] + "]");
                recorrer = recorrer.enlace; 
            }

        }

        public void eleminarnodo(String eleme)
        {
            Nodo Actual;
            Actual = inicio;
            Nodo Anterior;
            Anterior = null;
            bool encontrado = false;
            if(inicio != null)
            {
                while (Actual != null && encontrado != true)
                {
                    if(Actual.dato[0] == eleme )
                    {
                        if(Actual==inicio)
                        {
                            inicio = inicio.enlace;
                        }
                        else if(Actual==fin)
                        {
                            Anterior.enlace = null;
                            fin = Anterior;
                        }
                        else
                        {
                            Anterior.enlace = Actual.enlace;
                        }
                        //MessageBox.Show("nodo elimidado");
                        encontrado = true;
                    }
                    Anterior = Actual;
                    Actual = Actual.enlace;
                }
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
                    return recorrer.dato ;
                }
                recorrer = recorrer.enlace;
            }
            datos[0] = null;
            return datos;
        }
    }
}
