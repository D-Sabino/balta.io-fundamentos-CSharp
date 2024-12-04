using System;

namespace EditorHtml{
    public static class Menu{
        public static void Show(){
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
        }

        public static void DrawScreen(){
            gColunasInicioFim(30);
            gLinhas(6, 30);
            gColunasInicioFim(30);

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