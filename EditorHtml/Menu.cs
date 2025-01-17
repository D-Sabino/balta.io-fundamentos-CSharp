using System;

namespace EditorHtml {
    public static class Menu {
        public static void Show() {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            // Garantir que o tamanho do console seja suficiente
            AjustarConsole(40, 15);

            DrawScreen();
            WriteOptions();

            try {
                Console.SetCursorPosition(10, 12); // Posiciona o cursor na frente de "Opção:"
                var option = short.Parse(Console.ReadLine());
                HandleMenuOption(option);
            } catch (Exception) {
                Console.WriteLine("Opção inválida. Tente novamente.");
                Show();
            }
        }

        public static void DrawScreen() {
            int totalColunas = 34; // Largura do menu
            int totalLinhas = 10; // Altura do menu

            gColunasInicioFim(totalColunas);
            gLinhas(totalLinhas, totalColunas);
            gColunasInicioFim(totalColunas);
        }

        public static void WriteOptions() {
            Console.SetCursorPosition(10, 2); // Centralizado na largura de 34
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(10, 3);
            Console.WriteLine("==================");
            Console.SetCursorPosition(5, 4);
            Console.WriteLine("Selecione uma opção abaixo:");
            Console.SetCursorPosition(5, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(5, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(5, 8);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(10, 12);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOption(short option) {
            switch (option) {
                case 1:
                    Editor.Show();
                    break;
                case 2:
                    Console.WriteLine("View");
                    break;
                case 0:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    Show();
                    break;
            }
        }

        public static void gColunasInicioFim(int totalColunas) {
            Console.Write("+");
            for (int i = 0; i < totalColunas; i++) {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }

        public static void gLinhas(int totalLinhas, int totalColunas) {
            for (int lines = 0; lines < totalLinhas; lines++) {
                Console.Write("|");
                for (int i = 0; i < totalColunas; i++) {
                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }
        }

        private static void AjustarConsole(int largura, int altura) {
            if (Console.WindowWidth < largura) Console.WindowWidth = largura;
            if (Console.WindowHeight < altura) Console.WindowHeight = altura;

            if (Console.BufferWidth < largura) Console.BufferWidth = largura;
            if (Console.BufferHeight < altura) Console.BufferHeight = altura;
        }
    }
}
