using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Torres_de_Hanoi
{

    class Hanoi
    {

        //METODO MOVER_DISCO
        public void mover_disco(Pila a, Pila b)
        {
            //Si hay una pila vacia
            if (a.isEmpty() && b.Top != 0)//si a está vacio y b no es 0
            {
                Disco discoMovido = b.pop();
                a.push(discoMovido);//movemos el disco a A


                Console.WriteLine("Movimiento de disco con valor: " + discoMovido.Valor);//imprimimos por pantalla



            }
            else if (!a.isEmpty() && b.isEmpty())//si a no está vacío y b está vacío
            {
                Disco discoMovido = a.pop();
                b.push(discoMovido);//movemos el disco a B

                Console.WriteLine("Movimiento de disco con valor: " + discoMovido.Valor);//imprimimos por pantalla

            }
            else
            {
                //dos pilas llenas
                int inicio = a.Top;
                int final = b.Top;
                if (inicio > final)//si la pila inicial es mayor que la final
                {
                    //B->A
                    Disco discoMovido = b.pop();
                    a.push(discoMovido);//movemos el disco a A

                    Console.WriteLine("Movimiento de disco con valor: " + discoMovido.Valor);//imprimimos por pantalla
                }
                else
                {
                    //A->B
                    Disco discoMovido = a.pop();
                    b.push(discoMovido);//movemos el disco a B

                    Console.WriteLine("Movimiento de disco con valor: " + discoMovido.Valor);//imprimimos por pantalla
                }
            }



        }

        //METODO ITERATIVO
        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int numero_movimientos = 0;//inicializamos a 0 el numero de movimientos
            bool noSolucionado = true;//inicializamos un semaforo a verdadero de no solucionado

            if (n % 2 != 0)//si es par
            {
                while (noSolucionado)
                {


                    mover_disco(ini, fin);//movemos disco ini->fin
                    numero_movimientos++;//añadimos un movimiento

                    if (fin.Tamaño == n)//si el tamaño de fin es igual a n
                    {
                        noSolucionado = false;//semaforo a falso
                        break;
                    }

                    mover_disco(ini, aux);//movemos disco ini->aux
                    numero_movimientos++;//añadimos un movimiento
                    if (fin.Tamaño == n)//si el tamaño de fin es igual a n
                    {
                        noSolucionado = false;//semaforo a falso
                        break;
                    }

                    mover_disco(aux, fin);//movemos disco aux->fin
                    numero_movimientos++;//añadimos un movimiento
                    if (fin.Tamaño == n)//si el tamaño de fin es igual a n
                    {
                        noSolucionado = false;//semaforo a falso
                        break;
                    }


                }

            }

            
            //si es par
            if (n % 2 == 0)
            {
                while (noSolucionado)
                {

                    mover_disco(ini, fin);//movemos disco de ini->fin
                    
                    numero_movimientos++;//añadimos un movimiento

                    if (fin.Tamaño == n)//si el tamaño de fin es n
                    {
                        noSolucionado = false;//semaforo falso
                        
                        break;
                    }

                    mover_disco(ini, aux);//movemos el disco de ini->aux
                    
                    numero_movimientos++;//añadimos un movimiento

                    if (fin.Tamaño == n)//si tamaño de fin es igual a n
                    {
                        noSolucionado = false;//semaforow a falso
                        
                        break;
                    }

                    mover_disco(aux, fin);//movemos el disco de aux->fin
                    
                    numero_movimientos++;//añadimos un movimiento

                    if (fin.Tamaño == n)//si tamtaño de fin es n
                    {   
                        noSolucionado = false;//semaforo a falso
                        
                        break;
                    }


                }

            }
            //devolvemos el numero de movimientos
            return numero_movimientos;
        }

    }
}
    
