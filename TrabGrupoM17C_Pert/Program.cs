using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabGrupoM17C_Pert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];

            int maximo = numeros[0];
            Console.WriteLine("maximo {1}.", maximo);

            int indice = 0;
            Console.WriteLine("indice {1}.", indice);


            for (int i = 0; i < numeros.Length; i++)
            {
                if(numeros[i] > maximo)
                {
                    maximo = numeros[i];
                    indice = i;
                }

            }

            Console.WriteLine();

            int maior = ObterMaior(numeros);
            Console.WriteLine($"Maior -> {maior}");
            Console.ReadKey();
        }

        static int ObterMaior(int[] num)
        {
            int maior = num[0];

            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] > maior)
                {
                    maior = num[i];
                }
            }

            return maior;
        }
    }
}

