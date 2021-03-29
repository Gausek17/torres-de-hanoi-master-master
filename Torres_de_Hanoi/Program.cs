using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Iniciamos los discos según su tamaño
            Disco discoPequenyo = new Disco(1);//disco pequeño

            Disco discoMediano = new Disco(2);//disco mediano

            Disco discoGrande = new Disco(3);//disco grande


            // Iniciamos las pilas según su posición
            Pila pilaInicial = new Pila();//primera pila

            Pila pilaAux = new Pila();//segunda pila

            Pila pilaFinal = new Pila();//tercera pila

           
            //Insertamos los discos en las pilas
            pilaInicial.push(discoGrande);//ponemos disco grande en primera pila

            pilaInicial.push(discoMediano);//ponemos disco mediano en primera pila

            pilaInicial.push(discoPequenyo);//ponemos disco pequeño en primera pila


            //Entramos en Hanoi y usamos sus metodos
            Hanoi objetoHanoi = new Hanoi();//iniciamos Hanoi

            int resultado = objetoHanoi.iterativo(3, pilaInicial, pilaFinal, pilaAux);//definimos el resultado iterativo
            
            Console.WriteLine("\nNumero de movimientos totales= " + resultado);//imprimimos por pantalla el numero de movimientos
            if (resultado == 7)//si el resultado es 7
            {

                Console.WriteLine("\nEl programa va bien");//para comprobar si el programa funciona correctamente
            }

            Console.ReadKey();//termina el programa
        }
    }//fin de programa
}
