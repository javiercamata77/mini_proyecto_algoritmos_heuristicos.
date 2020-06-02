using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algoritmo_asterisco
{
    public partial class FormMatriz : Form
    {
        int colunma, fila, vecinos = 0, cont = 0;
        
        lista milista = new lista();
        listaabierta milistaabierta = new listaabierta();
        String[] elementos;
        String[] posActual;
        String final = "no";


        private void datamatriz_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {       
                datamatriz.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                datamatriz.Rows[e.RowIndex].Cells[e.ColumnIndex].Value =null;
        }

        private void datamatriz_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                for (int i = 0; i < datamatriz.RowCount; i++)

                    for (int j = 0; j < datamatriz.ColumnCount; j++)
                    {
                        //valor = valor + 1;
                        //datamatriz.Rows[i].Cells[j].Value = valor;
                        if (datamatriz.Rows[i].Cells[j].Value != null && datamatriz.Rows[i].Cells[j].Value.ToString() == "Inicio")
                        {
                            datamatriz.Rows[i].Cells[j].Value = null;

                        }
                    }
                datamatriz.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Inicio";
            }
            else if (checkBox2.Checked == true)
            {
                for (int i = 0; i < datamatriz.RowCount; i++)

                    for (int j = 0; j < datamatriz.ColumnCount; j++)
                    {                      
                        if (datamatriz.Rows[i].Cells[j].Value != null && datamatriz.Rows[i].Cells[j].Value.ToString() == "Fin")
                            datamatriz.Rows[i].Cells[j].Value = null;
                    }
                datamatriz.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Fin";
            }
            else
            {
                datamatriz.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                datamatriz.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Obstaculo";
            }
            /*string msg = String.Format("Row: {0}, Column: {1}",
        datamatriz.CurrentCell.RowIndex,
        datamatriz.CurrentCell.ColumnIndex);
            MessageBox.Show(msg, "Current Cell");*/
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < datamatriz.RowCount; i++)
            {
                for (int j = 0; j < datamatriz.ColumnCount; j++)
                {
                    if (datamatriz.Rows[i].Cells[j].Value != null)
                    {
                        if (datamatriz.Rows[i].Cells[j].Value.ToString() == "Inicio")
                        {
                            elementos = new String[4];
                            elementos[0] = Convert.ToString(datamatriz.Rows[i].Cells[j].Value);
                            elementos[1] = "0";
                            elementos[2] = "0";
                            elementos[3] = "0";
                            milista.agregarelemntos(elementos);
                            posActual = new String[4];
                            posActual = elementos;
                            //MessageBox.Show("posicion actual " + posActual[0]);
                            insertarvecinos(i, j);
                            buscarmenorF();
                            //MessageBox.Show("posicion actual " + posActual[0]);
                        }
                    }
                }
            }


            while (final != "Fin")
            {
            for (int i = 0; i < datamatriz.RowCount; i++)
            {
                for (int j = 0; j < datamatriz.ColumnCount; j++)
                {
                    if (datamatriz.Rows[i].Cells[j].Value != null)
                    {
                        
                        if(datamatriz.Rows[i].Cells[j].Value.ToString() == posActual[0] && final!="Fin")
                            {
                                //MessageBox.Show("entro");
                                //MessageBox.Show("entro en i="+i+" y j= "+j );
                                //MessageBox.Show("final= " + final);
                                insertarvecinos(i, j);
                                buscarmenorF();

                            }

                    }


                    //valor = valor + 1;
                    //datamatriz.Rows[i].Cells[j].Value = valor;
                    /*string x = datamatriz.CurrentRow.Cells[j].Value.ToString();
                    MessageBox.Show(x);
                    
                    else
                        //if(datamatriz.Rows[i].Cells[j].Value == null)
                        MessageBox.Show("aqui no esta ");*/

                }
            }            //milistaabierta.mostrarelementos();
            //MessageBox.Show("posicion actual " + PosicionActual[0]);
        }
            MessageBox.Show("termino la busqueda!! la Ruta es..........");

            // milista.mostrarelementos();

            ruta();
        }

        public void insertarvecinos(int fila, int columna)
        {
            int g=0,h;
            int aux1 = 0, n = 0,m=0;

            //para arriba
            if (fila == 0)
            {
               // MessageBox.Show("fila= " + fila);
                n = 3;
            }
            if (columna == 0)
            {
                        aux1 = 0;
                        n++;
             }
            else if (columna ==1)
            {
                aux1 = 1;
                n = 0;
            }
            else if (columna < datamatriz.ColumnCount - 1 && fila!= 0)
            {
                aux1 = columna+1;
                n = 0;
            }
            else if (columna == datamatriz.ColumnCount - 1)
            {
                aux1 = 3;
                n++;
            }
            
            for (int i=n; i<3;i++)
            {
                if(i%2==0)
                {
                    g = 14;
                    //MessageBox.Show("es par " + g);
                }
                else if(i % 2 != 0)
                {
                    g = 10;
                    //MessageBox.Show("es impar " + g);
                }
                if (datamatriz.Rows[fila - 1].Cells[aux1 - columna].Value == null)
                {
                    datamatriz.Rows[fila - 1].Cells[aux1 - columna].Value = ++vecinos;

                    elementos[0] = Convert.ToString(datamatriz.Rows[fila - 1].Cells[aux1 - columna].Value);
                    elementos[1] = Convert.ToString(g);
                    h = 10 * calculoH(Convert.ToString(datamatriz.Rows[fila - 1].Cells[aux1 - columna].Value));
                    elementos[2] = Convert.ToString(h);
                    elementos[3] = Convert.ToString(g + h);
                    milistaabierta.agregarelemntos(elementos);

                    //MessageBox.Show("recorrido "+g);
                    aux1++;
                }
                else if (Convert.ToString(datamatriz.Rows[fila -1].Cells[aux1- columna].Value) == "Fin")
                {
                    final="Fin";
                    //MessageBox.Show("llego" + final);
                }
                else
                {
                    aux1++;
                }
            }

            //a la izquierda
            if (columna < datamatriz.ColumnCount - 1)
            {
                if (datamatriz.Rows[fila].Cells[columna + 1].Value == null)
                {
                    datamatriz.Rows[fila].Cells[columna + 1].Value = ++vecinos;
                    elementos[0] = Convert.ToString(datamatriz.Rows[fila].Cells[columna+1].Value);
                    elementos[1] = "10";
                    h = 10 * calculoH(Convert.ToString(datamatriz.Rows[fila].Cells[columna+1].Value));
                    elementos[2] = Convert.ToString(h);
                    elementos[3] = Convert.ToString(10 + h);
                    milistaabierta.agregarelemntos(elementos);
                }
                
                 if (Convert.ToString(datamatriz.Rows[fila].Cells[columna + 1].Value) == "Fin")
                    {
                    final = "Fin";
                    //MessageBox.Show("llego" + final);
                }
                
            }


            //para abajo

            if(fila==datamatriz.RowCount -1 )
            {
                //MessageBox.Show("fila= " + fila+"ultima fila= "+Convert.ToString(datamatriz.RowCount - 1));
                m = 0;
            }
            if (columna == 0)
            {
                aux1 = 1;
                m=2;
            }
            else if(columna < datamatriz.ColumnCount - 1 && fila != datamatriz.RowCount - 1)
            {
                aux1 = 1;
                m = 3;
            }
            else if(columna== datamatriz.ColumnCount - 1)
            {
                aux1 = 0;
                m = 2;
            }

            for (int i = m; i > 0; i--)
            {
                if (i % 2 == 0)
                {
                    g = 14;
                    //MessageBox.Show("es par " + g);
                }
                else if (i % 2 != 0)
                {
                    g = 10;
                    //MessageBox.Show("es impar " + g);
                }
                if (datamatriz.Rows[fila +1].Cells[aux1 + columna].Value == null)
                {
                    datamatriz.Rows[fila +1].Cells[aux1 + columna].Value = ++vecinos;
                    elementos[0] = Convert.ToString(datamatriz.Rows[fila + 1].Cells[aux1 + columna].Value);
                    elementos[1] = Convert.ToString(g);
                    h = 10 * calculoH(Convert.ToString(datamatriz.Rows[fila + 1].Cells[aux1 + columna].Value));
                    elementos[2] = Convert.ToString(h);
                    elementos[3] = Convert.ToString(g+ h);
                    milistaabierta.agregarelemntos(elementos);
                    aux1--;
                }
                else if (Convert.ToString(datamatriz.Rows[fila +1].Cells[aux1 + columna].Value) == "Fin")
                {
                    final = "Fin";
                   // MessageBox.Show("llego" + final);
                }
                else
                {
                    aux1--;
                }
            }

            //a la derecha
            if (columna !=0)
            {
                if (datamatriz.Rows[fila].Cells[columna - 1].Value == null)
                {
                    datamatriz.Rows[fila].Cells[columna - 1].Value = ++vecinos;
                    elementos[0] = Convert.ToString(datamatriz.Rows[fila].Cells[columna -1 ].Value);
                    elementos[1] = "10";
                    h = 10 * calculoH(Convert.ToString(datamatriz.Rows[fila].Cells[columna+1].Value));

                    elementos[2] = Convert.ToString(h);
                    elementos[3] = Convert.ToString(10 + h);
                    milistaabierta.agregarelemntos(elementos);
                }
                else if (Convert.ToString(datamatriz.Rows[fila].Cells[columna - 1].Value) == "Fin")
                {
                    final = "Fin";
                   //MessageBox.Show("llego" + final);
                }
            }

        }
        public void buscarmenorF()
        {
            String[] aux1;
            String[] aux2 = new String[4];
            int x = 0;
            for (int i = 0; i < datamatriz.RowCount; i++)
            {
                for (int j = 0; j < datamatriz.ColumnCount; j++)
                {
                    if (datamatriz.Rows[i].Cells[j].Value != null)
                    {
                        //MessageBox.Show("el valor es "+ datamatriz.Rows[i].Cells[j].Value);
                        //aux = new String[4];
                        aux1=milistaabierta.buscarlista(Convert.ToString(datamatriz.Rows[i].Cells[j].Value));
                        if (aux1[0] != null)
                        {
                            if (x == 0)
                            {
                                aux2 = aux1;
                                x++;
                            }
                            else
                            {
                                if (Convert.ToInt16(aux1[3]) < Convert.ToInt16(aux2[3]))
                                {
                                    aux2 = aux1;
                                }
                            }
                        } 

                        //MessageBox.Show("encontrol el "+aux1[0]);
                    }
                }
            }
            //MessageBox.Show("encontrol el " + aux2[0] + "con F= "+aux2[3]);
            posActual = aux2;
            //milista.agregarelemntos(posActual);
           // milistaabierta.mostrarelementos();
            milistaabierta.eleminarnodo(posActual[0]);
            if (final != "Fin")
            {
                milista.agregarelemntos(aux2);
            }
            //mostrarelementos();
        }

        public void Fmejora(int fila, int columna)
        {
            int g = 0, h;
            int aux1 = 0, n = 0, m = 0;
            String elem;
            String[] dato;
            //para arriba
            if (columna == 0)
            {
                aux1 = 0;
                n++;
            }
            else if (columna == 1)
            {
                aux1 = 1;
                n = 0;
            }
            else if (columna < datamatriz.ColumnCount - 1 && columna != 1)
            {
                aux1 = columna + 1;
                n = 0;
            }
            else if (columna == datamatriz.ColumnCount - 1)
            {
                aux1 = 3;
                n++;
            }

            for (int i = n; i < 3; i++)
            {
                if (i % 2 == 0)
                {
                    g = 14;
                    //MessageBox.Show("es par " + g);
                }
                else if (i % 2 != 0)
                {
                    g = 10;
                    //MessageBox.Show("es impar " + g);
                }
                if (datamatriz.Rows[fila - 1].Cells[aux1 - columna].Value != null && Convert.ToString(datamatriz.Rows[fila - 1].Cells[aux1 - columna].Value) != "obtaculo" )
                {
                    elem = Convert.ToString(datamatriz.Rows[fila - 1].Cells[aux1 - columna].Value);
                    dato = milistaabierta.buscarlista(elem);
                    if (g + Convert.ToInt16(dato[2]) < Convert.ToInt16(posActual[2]))
                    {
                        //MessageBox.Show("recorrido "+g);
                    }

                    aux1++;
                }
                else if (Convert.ToString(datamatriz.Rows[fila - 1].Cells[aux1 - columna].Value) == "Fin")
                {
                    final = "Fin";
                    MessageBox.Show("llego" + final);
                }
                else
                {
                    aux1++;
                }
            }

            //a la izquierda
            if (columna < datamatriz.ColumnCount - 1)
            {
                if (datamatriz.Rows[fila].Cells[columna + 1].Value == null)
                {
                    datamatriz.Rows[fila].Cells[columna + 1].Value = ++vecinos;
                    elementos[0] = Convert.ToString(datamatriz.Rows[fila].Cells[columna + 1].Value);
                    elementos[1] = "10";
                    h = 10 * calculoH(Convert.ToString(datamatriz.Rows[fila].Cells[columna + 1].Value));
                    elementos[2] = Convert.ToString(h);
                    elementos[3] = Convert.ToString(10 + h);
                    milistaabierta.agregarelemntos(elementos);
                }

                if (Convert.ToString(datamatriz.Rows[fila].Cells[columna + 1].Value) == "Fin")
                {
                    final = "Fin";
                    MessageBox.Show("llego" + final);
                }

            }


            //para abajo
            if (columna == 0)
            {
                aux1 = 1;
                m = 2;
            }
            else if (columna < datamatriz.ColumnCount - 1)
            {
                aux1 = 1;
                m = 3;
            }
            else if (columna == datamatriz.ColumnCount - 1)
            {
                aux1 = 0;
                m = 2;
            }

            for (int i = m; i > 0; i--)
            {
                if (i % 2 == 0)
                {
                    g = 14;
                    //MessageBox.Show("es par " + g);
                }
                else if (i % 2 != 0)
                {
                    g = 10;
                    //MessageBox.Show("es impar " + g);
                }
                if (datamatriz.Rows[fila + 1].Cells[aux1 + columna].Value == null)
                {
                    datamatriz.Rows[fila + 1].Cells[aux1 + columna].Value = ++vecinos;
                    elementos[0] = Convert.ToString(datamatriz.Rows[fila + 1].Cells[aux1 + columna].Value);
                    elementos[1] = Convert.ToString(g);
                    h = 10 * calculoH(Convert.ToString(datamatriz.Rows[fila + 1].Cells[aux1 + columna].Value));
                    elementos[2] = Convert.ToString(h);
                    elementos[3] = Convert.ToString(g + h);
                    milistaabierta.agregarelemntos(elementos);
                    aux1--;
                }
                else if (Convert.ToString(datamatriz.Rows[fila + 1].Cells[aux1 + columna].Value) == "Fin")
                {
                    final = "Fin";
                    MessageBox.Show("llego" + final);
                }
                else
                {
                    aux1--;
                }
            }

            //a la derecha
            if (columna != 0)
            {
                if (datamatriz.Rows[fila].Cells[columna - 1].Value == null)
                {
                    datamatriz.Rows[fila].Cells[columna - 1].Value = ++vecinos;
                    elementos[0] = Convert.ToString(datamatriz.Rows[fila].Cells[columna - 1].Value);
                    elementos[1] = "10";
                    h = 10 * calculoH(Convert.ToString(datamatriz.Rows[fila].Cells[columna + 1].Value));

                    elementos[2] = Convert.ToString(h);
                    elementos[3] = Convert.ToString(10 + h);
                    milistaabierta.agregarelemntos(elementos);
                }
                else if (Convert.ToString(datamatriz.Rows[fila].Cells[columna - 1].Value) == "Fin")
                {
                    final = "Fin";
                    MessageBox.Show("llego" + final);
                }
            }
        }
        public void buscarmejoras()
        {
            int fila=0, columna=0;
            for (int i = 0; i < datamatriz.RowCount; i++)
            {
                for (int j = 0; j < datamatriz.ColumnCount; j++)
                {
                    if (datamatriz.Rows[i].Cells[j].Value != null)
                    {
                        if (datamatriz.Rows[i].Cells[j].Value.ToString() == posActual[0])
                        {
                            fila = i;
                            columna = j;
                        }
                    }
                }
            }
            int g = 0, h;
            int aux1 = 0, n = 0, m = 0;
            String[] elem = new String[4];
            //para arriba
            if (columna == 0)
            {
                aux1 = 0;
                n++;
            }
            else if (columna < datamatriz.ColumnCount - 1)
            {
                aux1 = 1;
                n = 0;
            }
            else if (columna == datamatriz.ColumnCount - 1)
            {
                aux1 = 3;
                n++;
            }

            for (int i = n; i < 3; i++)
            {
                if (i % 2 == 0)
                {
                    g = 14;
                    //MessageBox.Show("es par " + g);
                }
                else if (i % 2 != 0)
                {
                    g = 10;
                    //MessageBox.Show("es impar " + g);
                }
                if (datamatriz.Rows[fila - 1].Cells[aux1 - columna].Value == null)
                {
                    milistaabierta.buscarlista(Convert.ToString(datamatriz.Rows[fila - 1].Cells[aux1 - columna].Value));
                }
                else
                {
                    aux1++;
                }
            }

            //a la izquierda
            if (columna < datamatriz.ColumnCount - 1)
            {
                if (datamatriz.Rows[fila].Cells[columna + 1].Value == null)
                {
                    
                }
            }


            //para abajo
            if (columna == 0)
            {
                aux1 = 1;
                m = 2;
            }
            else if (columna < datamatriz.ColumnCount - 1)
            {
                aux1 = 1;
                m = 3;
            }
            else if (columna == datamatriz.ColumnCount - 1)
            {
                aux1 = 0;
                m = 2;
            }

            for (int i = m; i > 0; i--)
            {
                if (i % 2 == 0)
                {
                    g = 14;
                    //MessageBox.Show("es par " + g);
                }
                else if (i % 2 != 0)
                {
                    g = 10;
                    //MessageBox.Show("es impar " + g);
                }
                if (datamatriz.Rows[fila + 1].Cells[aux1 + columna].Value == null)
                {
                    
                }
                else
                {
                    aux1--;
                }
            }

            //a la derecha
            if (columna != 0)
            {
                if (datamatriz.Rows[fila].Cells[columna - 1].Value == null)
                {
                   
                }
            }

        }

        public void ruta()
        {
            String[] aux;
            for (int i = 0; i < datamatriz.RowCount; i++)
            {
                for (int j = 0; j < datamatriz.ColumnCount; j++)
                {
                    if (datamatriz.Rows[i].Cells[j].Value != null)
                    {

                        aux = milista.buscarlista(Convert.ToString(datamatriz.Rows[i].Cells[j].Value));
                        if (aux[0] != null || aux[0]=="Fin")
                        {
                            datamatriz.Rows[i].Cells[j].Style.BackColor = Color.Green;
                        }
                        if(Convert.ToString(datamatriz.Rows[i].Cells[j].Value)=="Fin")
                        {
                            datamatriz.Rows[i].Cells[j].Style.BackColor = Color.Green;
                        }
                    }
                }

            }
        }
        public FormMatriz()
        {
            InitializeComponent();
            posActual = new String[4];
            posActual[0] = "todavia";
        }
        private void btnaplicar_Click(object sender, EventArgs e)
        {
            colunma = Convert.ToInt16(txtcolumnas.Text);
            fila = Convert.ToInt16(txtfilas.Text);
            datamatriz.ColumnCount = colunma;
            datamatriz.RowCount = fila;
        }
        public int calculoH(String dato)
        {
            int g = 0, auxi=0,auxj=0;

            //dato = new String[3];
            for (int i = 0; i < datamatriz.RowCount; i++)
            {

                for (int j = 0; j < datamatriz.ColumnCount; j++)
                {
                    if (datamatriz.Rows[i].Cells[j].Value != null)
                    {
                        if (datamatriz.Rows[i].Cells[j].Value.ToString() == dato)
                        {
                            auxi = i;
                            auxj = j;
                        }
                    }
                }
            }
            for (int i = 0; i < datamatriz.RowCount; i++)
            {

                for (int j = 0; j < datamatriz.ColumnCount; j++)
                {
                    if (datamatriz.Rows[i].Cells[j].Value != null)
                    {
                        if (datamatriz.Rows[i].Cells[j].Value.ToString() == "Fin")
                        {

                            if (auxi == i)
                            {
                                g = j - auxj;
                            }
                            else if (auxi < i)
                            {
                                g = (i - auxi) + (j - auxj);
                            }
                            else if (auxi > i)
                            {
                                g = (auxi - i) + (j - auxj);
                            }

                        }
                    }
                }
            }


            //MessageBox.Show("g = "+g);
            return g;
        }
    }
}
