using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Usando_variaveis_flutuantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a 3ªExecução do nosso aprendizado...Agora fique com...VARIAVEIS FLUTUANTES !");

            //NÃO PODEMOS USAR VALORES COM CASAS DECIMAIS, COM VIRGULA EM UMA VAR INT
            double salario = 1950.36;
            Console.WriteLine("Seu salario é R$ " + salario);

            //Exemplos de Execução do DOUBLE

            double aluguel= 830.15;
            Console.WriteLine("O valor do aluguel é de R$ " + aluguel);

            double saldo = salario - aluguel;


            Console.WriteLine("O saldo restante é de R$ " + saldo);


            Console.WriteLine("Aperte ENTER para finalizar");
         
            Console.ReadLine();
        


        }
    }
}
