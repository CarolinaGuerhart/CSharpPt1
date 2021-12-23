using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Usando_variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando com variaveis");

            int idade;
            idade = 21;
            Console.WriteLine(idade);

            idade = 15;
            Console.WriteLine(idade);

            idade = 15 + 15;
            Console.WriteLine(idade);

            idade = 30 - 2 + 6 * 10;
            Console.WriteLine(idade);


            idade = 21;
            Console.WriteLine("Você tem " + idade + " anos !");
      
            Console.WriteLine("Aperte ENTER para finalizar");

            Console.ReadLine();

           





        }
    }
}
