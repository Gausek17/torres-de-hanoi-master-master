using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        //inicio Main
        static void Main(string[] args)
        {

            bool follow = true;

            Console.WriteLine("Inicio Programa TORRES DE HANOI");

            while (follow)
            {
                // Pedimos al usuario el numero de discos
                Console.WriteLine("Introduzca numero de piezas: ");
                
                //convertimos m en un numero entero
                int n = Convert.ToInt32(Console.ReadLine());

                // crear las 3 pilas y el objeto hanoi
                Pila p1 = new Pila("INI");
                Pila p2 = new Pila("FIN");
                Pila p3 = new Pila("AUX");

                Hanoi h = new Hanoi();

                // añadir los n discos a la pila ini
                for (int i = n; i >= 1; i--)
                {
                    p1.push(new Disco(i));
                }

                Console.WriteLine(p1.ToString());
                Console.WriteLine(p3.ToString());
                Console.WriteLine(p2.ToString());

                Console.WriteLine("Se completo en: " + h.iterativo(p1.Elementos.Count, p1, p2, p3) + " movimientos");

                //Console.WriteLine("Se completo en: " + h.recursivo(p1.Elementos.Count, p1, p2, p3) + " movimientos");

                Console.WriteLine("El número mínimo de movimientos para " + n + " piezas es: " + (Math.Pow(2, n) - 1));

                Console.WriteLine("Pulsa 'q' para salir o cualquier otra para repetir");
                char c = Console.ReadLine()[0];
                if (c.Equals('q'))
                {
                    follow = false;
                }
            }


        }
    }
}