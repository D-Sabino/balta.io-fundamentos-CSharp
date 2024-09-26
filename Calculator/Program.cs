using System;

namespace Calculator{
    class Program{
        static void Main(string[] args){
            menu();
        }

        static void menu(){
            Console.Clear();
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("---------------");

            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch(res){
                case 1: soma(); break;
                case 2: subtracao(); break;
                case 3: divisao(); break;
                case 4: multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: menu(); break;

            }

        }

        static void soma(){
            Console.Clear();
             Console.WriteLine("SOMA:");
            Console.WriteLine("Primeiro valor: ");
            float valor_1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Segundo valor: ");
            float valor_2 = float.Parse(Console.ReadLine());

            float resultado = valor_1 + valor_2;
            Console.WriteLine("");
            Console.WriteLine("A soma é " + resultado);
            Console.ReadKey();
            menu();
        }

        static void subtracao(){
            Console.Clear();

            Console.WriteLine("SUBTRAÇÃO:");

            Console.WriteLine("Primeiro valor: ");
            float valor_1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Segundo valor: ");
            float valor_2 = float.Parse(Console.ReadLine());

            float resultado = valor_1 - valor_2;
            Console.WriteLine("");
            Console.WriteLine("A subtração é " + resultado);

            Console.ReadKey();
            menu();
        }

        static void divisao(){
            Console.Clear();

            Console.WriteLine("DIVISÃO:");

            Console.WriteLine("Primeiro valor: ");
            float valor_1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor_2 = float.Parse(Console.ReadLine());

            float resultado = valor_1 / valor_2;
            Console.WriteLine("");
            Console.WriteLine($"A divisão é {resultado}");

            Console.ReadKey();

            menu();
        }

        static void multiplicacao(){
            Console.Clear();
            Console.WriteLine("MULTIPLICAÇÃO:");

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é {resultado}");

            Console.ReadKey();

            menu();
        }
    }
}