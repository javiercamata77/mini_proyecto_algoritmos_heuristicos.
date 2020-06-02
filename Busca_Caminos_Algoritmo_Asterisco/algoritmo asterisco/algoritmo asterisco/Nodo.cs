using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmo_asterisco
{
    public class Nodo
    {
        public String[] dato=new String[4];
        public Nodo enlace;

        //constructor para insertar elemntos
        public Nodo(String[] dato, Nodo enlace)
        {
            for (int i = 0; i < dato.Length; i++)
            { 
                this.dato[i] = dato[i]; 
            }
            
            this.enlace = enlace;
        }
    }
}
