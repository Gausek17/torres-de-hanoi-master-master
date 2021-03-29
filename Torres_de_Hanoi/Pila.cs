using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get { return Elementos.Count; } } //tamaño elementos pila



        public int Top { get; set; }//declaramos top(valor del disco que tiene)



        public List<Disco> Elementos { get; set; }//lista discos


        public Pila()//constructor pila
        {


            Top = 0;//inicializamos top sin elementos
            Elementos = new List<Disco>();//elementos de la lista disco

        }

        public void push(Disco d)//apilar discos
        {
            Elementos.Add(d);//añadimos el disco

            Top = d.Valor;//cogemos el valor del disco


        }
        

        public Disco pop()//desapilar
        {


            Disco extraido = null;//no hay disco extraido

            if (Size == 0)//si el tamaño es 0
            {
                Top = 0;//top valdrá 0
            }

            else//si no
            {


                extraido = Elementos[Size - 1];//extraido valdrá el tamaño menos uno
                Elementos.RemoveAt(Size - 1);//borramos el elemento de la posición
                if (Size == 0)//si el tamaño es 0
                {
                    Top = 0;//top es 0
                }
                else//si no
                {
                    Top = Elementos[Size - 1].Valor;//top valdrá el tamaño menos uno

                }

            }

            return extraido;//devolvemos el extraido

        }

        public bool isEmpty()//si esta vacio
        {


            if (Elementos.Count == 0)//si los elementos son 0
            {
                return true;//devolvemos verdadero
            }
            else//sino
            {
                return false;//devolvemos false
            }

        }



    }//final de la clase
}
