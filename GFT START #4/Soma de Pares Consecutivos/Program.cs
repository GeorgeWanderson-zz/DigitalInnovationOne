using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dio
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());

            while (X != 0)
            {
                int cont = 0;
                int soma = X;
                int result = X;
                if (X % 2 == 0)
                {
                    while (cont < 4)
                    {
                        soma += 2;
                        result += soma;
                        cont++;
                    }
                    Console.WriteLine(result);
                }
                else if (X % 2 != 0)
                {
                    soma += 1;
                    result += 1;
                    while (cont < 4)
                    {
                        soma += 2;
                        result += soma;
                        cont++;
                    }
                    Console.WriteLine(result);

                }
                X = int.Parse(Console.ReadLine());
            }
        }
    }
}
