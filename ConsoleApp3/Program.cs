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

            for(int i=0; i <num2; i++)
            {
                resultado += num1;
            }

            Console.WriteLine(num1 + " x " +num2 + " = " + resultado);

            //Dividindo
            resultado = 0;
            int aux1 = num1;
            while(aux1 >= num2)
            {
                aux1 -= num2;
                resultado += 1;
            }


            Console.WriteLine(num1 + " / " + num2 + " = " + resultado);


            Console.ReadKey(); // system.pause
        }
    }
}
