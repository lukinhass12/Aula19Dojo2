  
using System;

namespace Aula19Dojo2
{
    class Program
    {
        
        static void Main(string[] args)
        {

            IngressoVip passagem = new IngressoVip();
            passagem.IngressoPreco = 10.00f;
            passagem.ImprimirValor();
            passagem.AdicionarValor();

            System.Console.WriteLine("A diferença de valores é: " + passagem.valorAdicional + "reais.");
            
        }
    }
}