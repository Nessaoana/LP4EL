using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o 1° num: \n");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Digite o 2° num: \n");
            int num2 = Int32.Parse(Console.ReadLine());
            int resultado=0;

           
            // Multiplicando

            resultado = Multiplicar(num1, num2);


            Console.WriteLine(num1 + " x " +num2 + " = " + resultado);

            //Dividindo
            int[] result = Dividir(num1, num2);


            Console.WriteLine("Divisão -> " + num1 + " / " + num2 + " = " + result[0]);
            Console.WriteLine("Resto da divisão -> " + num1 + " / " + num2 + " = " + result[1]);

            int[] Dividir(int i, int y)
            {
                int r = 0;
                int aux1 = i;

                int[] re = new int[2];

                while (aux1 >= y)
                {
                    aux1 -= y;
                    r += 1;
                }

                re[0] = r;
                re[1] = aux1;

                return re;
            }

            int Multiplicar(int i, int y){

                int re;

                 for(int i=0; i <num2; i++)
                 {
                    re += num1;
                 }

                 return re;
            }

            Console.ReadKey(); // system.pause
        }
    }
}