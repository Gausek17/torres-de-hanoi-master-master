using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            
        }

        public int iterativo(int n, Pila ini, Pila aux, Pila fin)
        {
            if (n == 1)
            {
                cout << "Mover disco desde" << ini << "a" << aux << endl;
            }
            else
            {
                iterativo(n - 1, ini, fin, aux);
                cout << "Mover disco desde" << ini << "a" << aux << endl;
                iterativo(n - 1, fin, aux, ini);
            }
        }

    }
}
