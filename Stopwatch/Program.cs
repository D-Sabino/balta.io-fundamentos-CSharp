using System;
using System.Threading;

namespace Stopwatch{
    class Program{
        static void Main(string[] args){
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("S - Segundos => 10s = 10 segundos");
            Console.WriteLine("M - Minutos => 1m = 1 minuto");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string dados = Console.ReadLine().ToLower();

            if (dados == "0")
                System.Environment.Exit(0);
            else if(string.IsNullOrEmpty(dados) || dados.Length < 2){
                Console.WriteLine("Entrada inválida. Tente novamente.");
                Thread.Sleep(2000);
                Menu();
                return;
            }

            char type = dados[dados.Length - 1];
            if (type != 's' && type != 'm'){
                Console.WriteLine("Unidade de tempo inválida. Use 's' para segundos ou 'm' para minutos.");
                Thread.Sleep(2000);
                Menu();
                return;
            }


            string timeString = dados.Substring(0, dados.Length - 1);
            if(!int.TryParse(timeString, out int time) || time <= 0){
                Console.WriteLine("Tempo inválido. Tente novamente.");
                Thread.Sleep(2000);
                Menu();
                return;
            }


            int multiplier = 1;
            if (type == 'm')
                multiplier = 60;
            
            PreStart(time * multiplier);
            

        }

        static void PreStart(int time){
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);

            Console.Clear();
            Console.WriteLine("Set...");
            Thread.Sleep(1000);

            Console.Clear();
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }

        static void Start(int time){
            int currentTime = 0;

            while(currentTime != (time + 1)){
                Console.Clear();
                int hours = currentTime / 3600;
                int minutes = (currentTime % 3600) / 60;
                int seconds = currentTime % 60;

                string formattedTime = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
                Console.WriteLine(formattedTime);
                Thread.Sleep(1000);
                currentTime++;
            }

            Thread.Sleep(2500);
            Console.Clear();
            Console.WriteLine("Stopwatch finalizado.");
            Thread.Sleep(2500);

            Menu();
        }

    }
}