using System;

namespace Calculator{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Primeiro valor: ");
            float valor_1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Segundo valor: ");
            float valor_2 = float.Parse(Console.ReadLine());

            float resultado = valor_1 + valor_2;
            Console.WriteLine("");
            Console.WriteLine("A soma é " + resultado);
        }
    }
}