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

            // pilas
            Pila pilaInicial = new Pila();

            Pila pilaAux = new Pila();

            Pila pilaFinal = new Pila();

            //discos 
            Disco discoPequenyo = new Disco(1);

            Disco discoMediano = new Disco(2);

            Disco discoGrande = new Disco(3);


            //Insertamos los discos en las pilas
            pilaInicial.push(discoGrande);

            pilaInicial.push(discoMediano);

            pilaInicial.push(discoPequenyo);


            //Entramos en Hanoi y usamos sus metodos
            Hanoi objetoHanoi = new Hanoi();

            int resultado = objetoHanoi.iterativo(3, pilaInicial, pilaFinal, pilaAux);

            Console.WriteLine("\nNumero de movimientos totales= " + resultado);
            if (resultado == 7)
            {

                Console.WriteLine("\nEl programa va bien");
            }

            Console.ReadKey();
        }
    }
}
