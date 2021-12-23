using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Aprendendo_outras_formas_de_variaveis_numericas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4...Conversões e outras formas de variaveis");

            //exemplo de conversão, nesse caso se perde os numeros pós virgula 0,45 
            double total = 2200.45;
            int totalInteiro = (int)total;
            Console.WriteLine("O total é de : " + totalInteiro+ " famoso type casting, na qual há conversão");

            Console.WriteLine("Tipos de variaveis numericas em 3...2..1");


            
            long valor1 = 64;
            Console.WriteLine("Valores acima de 2 Bilhões, variavel de "+valor1+" bits");

            int valor2 = 32;
            Console.WriteLine("Valores até 2Bilhões, variavel de " + valor2 + " bits");

            short valor3 = 16;
            Console.WriteLine("Valores até 16mil, variavel de " +valor3+ " bits");

            Console.WriteLine("Float ou Double ?");

            //Precisão curta em relação ao double, sempre usar F no final dos float
            float cm = 1.98f;
            double km = 200.30;
            Console.WriteLine("A diferença entre float e double está na capacidade de " +
                " armazenamento por exemplo float tem uma capacidade menor de "+cm+ "cm, já o double " +
                "tem uma capacidade maior de "+km+"km , por exemplo.");


            Console.ReadLine();
        }
    }
}
