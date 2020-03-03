using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFibonacci
{
    class Program
    {
         static void Main()
        {
            var Desafio = new Program();
            var testeNumero = Desafio.IsFibonnaci(4);
            if (testeNumero is true)
            {
                Console.WriteLine("Numero encontrado na sequencia Fibonacci");
            }
            else
            {
                Console.WriteLine("Numero NÃO encontrado na sequencia Fibonacci");
            }
            Console.WriteLine("Fim aplicacao");
        }


        public bool IsFibonnaci(int numero)
        {
            List<int> lista = Fibonacci();

            if (lista.Contains(numero)) return true;
          
            return false; ;
        }



        public List<int> Fibonacci()
        {
            List<int> listaFibanocci = new List<int>();
            listaFibanocci.Add(0);
            int ultimo = 0;


            for (int i = 0; ultimo < 351; i++)
            {

                int a = listaFibanocci.Count();

                if (a < 3)
                {
                    ultimo = a;
                }
                else
                {
                    ultimo = listaFibanocci[a - 1] + listaFibanocci[a - 2];
                }

                if (ultimo < 351) listaFibanocci.Add(ultimo);

            }

            return listaFibanocci;

        }
    }
}
