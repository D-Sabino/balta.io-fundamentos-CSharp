using System;

namespace EditorHtml{
    public static class Menu{
        public static void Show(){
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());

        }

        public static void DrawScreen(){
            gColunasInicioFim(30);
            gLinhas(6, 30);
            gColunasInicioFim(30);

        }

        public static void WriteOptions(){
            Console.SetCursorPosition(3,2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3,3);
            Console.WriteLine("================");
            Console.SetCursorPosition(3,4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3,6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3,7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3,9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3,10);
            Console.Write("Opção: ");
            
        }

        public static void gColunasInicioFim(int totalColunas){
            Console.Write("+");
            for (int i = 0; i <= totalColunas; i++){
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }

        public static void gLinhas(int totalLinhas, int totalColunas){
            for(int lines = 0; lines <= totalLinhas; lines++){
                Console.Write("|");
                for (int i = 0; i <= totalColunas; i++){
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }
        }

    }

   
}