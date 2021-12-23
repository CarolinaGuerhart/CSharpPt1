using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Variaveis_em_TEXTO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5/Caracteres em Variaveis");

            //char usa somente aspas simples 'ex' e suporta 1 caracter 

            char Letra1 = 'a';
            Console.WriteLine(Letra1);

            //Casting, aceitando numeros no caracter 
            //ASCii é uma tabela com diversos numeros que são transformados em caracteres

            Letra1 = (char)65;
            Console.WriteLine(Letra1);
            
            //é necessario o uso de parenteses para unir a var com o numero 
            Letra1 = (char)(Letra1 + 1);
            Console.WriteLine(Letra1);

            //STRING é usada para textos, palavras para pular linhas use o @

            string palavra = ("Estamos avançando em nosso aprendizado");
            Console.WriteLine(palavra);

            string EmLinhas =
                @"1.Um, dois, Freddy está vindo para você!
                2.Três, quatro, melhor trancar a porta!
                3.Cinco, seis, pegue o seu crucifixo!
                4.Sete, oito, melhor ficar acordado até tarde!
                5.Nove, dez, você nunca mais vai dormir de novo!";
            Console.WriteLine(EmLinhas);
            
            Console.ReadLine();

        }
    }
}
