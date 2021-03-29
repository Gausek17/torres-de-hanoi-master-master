using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Torres_de_Hanoi
{

    class Hanoi
    {


        public void mover_disco(Pila a, Pila b)
        {
            //Si hay una pila vacia
            if (a.isEmpty() && b.Top != 0)
            {
                Disco discoMovido = b.pop();
                a.push(discoMovido);


                Console.WriteLine("Movimiento de disco con valor: " + discoMovido.Valor);



            }
            else if (!a.isEmpty() && b.isEmpty())
            {
                Disco discoMovido = a.pop();
                b.push(discoMovido);

                Console.WriteLine("Movimiento de disco con valor: " + discoMovido.Valor);

            }
            else
            {
                //dos pilas llenas
                int inicio = a.Top;
                int final = b.Top;
                if (inicio > final)
                {
                    //B->A
                    Disco discoMovido = b.pop();
                    a.push(discoMovido);

                    Console.WriteLine("Movimiento de disco con valor: " + discoMovido.Valor);
                }
                else
                {
                    //A->B
                    Disco discoMovido = a.pop();
                    b.push(discoMovido);

                    Console.WriteLine("Movimiento de disco con valor: " + discoMovido.Valor);
                }
            }



        }


        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int numero_movimientos = 0;
            bool noSolucionado = true;

            if (n % 2 != 0)
            {
                while (noSolucionado)
                {


                    mover_disco(ini, fin);
                    numero_movimientos++;

                    if (fin.Size == n)
                    {
                        noSolucionado = false;
                        break;
                    }

                    mover_disco(ini, aux);
                    numero_movimientos++;
                    if (fin.Size == n)
                    {
                        noSolucionado = false;
                        break;
                    }

                    mover_disco(aux, fin);
                    numero_movimientos++;
                    if (fin.Size == n)
                    {
                        noSolucionado = false;
                        break;
                    }


                }

            }


            if (n % 2 == 0)
            {
                while (noSolucionado)
                {

                    mover_disco(ini, fin);
                    numero_movimientos++;

                    if (fin.Size == n)
                    {
                        noSolucionado = false;
                        break;
                    }

                    mover_disco(ini, aux);
                    numero_movimientos++;

                    if (fin.Size == n)
                    {
                        noSolucionado = false;
                        break;
                    }

                    mover_disco(aux, fin);
                    numero_movimientos++;

                    if (fin.Size == n)
                    {
                        noSolucionado = false;
                        break;
                    }


                }

            }



            return numero_movimientos;
        }


    }
}
    
