using System;
using System.Threading;


namespace calculadora2
{
    class Program
    {
        public static void Menu() {

            Console.WriteLine("Seja bem-vindo a calculadora!");
            Console.WriteLine("*********************************");
            Console.WriteLine("*       O que deseja fazer?     *");
            Console.WriteLine("*         > 1 - Somar           *");
            Console.WriteLine("*         > 2 - Subtrair        *");
            Console.WriteLine("*         > 3 - Dividir         *");
            Console.WriteLine("*         > 4 - Multiplicar     *");
            Console.WriteLine("*********************************");
            Console.WriteLine("Escolha uma opção: ");
            short.TryParse(Console.ReadLine(), out short res);
            Console.Clear();

            switch (res) {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Divisao();
                    break;
                case 4:
                    Multiplicacao();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    Menu();
                    break;
            }
        }

        static void Soma() {
            Console.WriteLine($"Você escolheu SOMA!");
            Console.WriteLine("Insira o primeiro valor: ");
            double.TryParse(Console.ReadLine(), out double v1);
            Console.Clear();
            Console.WriteLine("Insira o segundo valor: ");
            double.TryParse(Console.ReadLine(), out double v2);
            Console.Clear();

            Console.WriteLine($"Primeiro valor inserido: {v1}");
            Console.WriteLine($"Segundo valor inserido: {v2}");

            var resultado = v1 + v2;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Resultado: {resultado}");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Digite 1 para voltar ao Menu ou 2 para fechar o programa!");
            int.TryParse(Console.ReadLine(), out int fim);

            if (fim == 1) {
                Menu();
            }
            else {
                Console.WriteLine("Programa finalizado!!! Pressione qualquer tecla para fechar o programa.");
            }

            //switch (fim) {
            //    case 1:
            //        Console.Clear();
            //        Menu();
            //        break;
            //    default:
            //        Console.Clear();
            //        Console.WriteLine("Programa finalizado!!! Pressione qualquer tecla para fechar o programa.");
            //        break;
            //}
        }

        static void Subtracao() {
            Console.WriteLine($"Você escolheu SUBTRAÇÃO!");
            Console.WriteLine("Insira o primeiro valor: ");
            double.TryParse(Console.ReadLine(), out double v1);
            Console.Clear();
            Console.WriteLine("Insira o segundo valor: ");
            double.TryParse(Console.ReadLine(), out double v2);
            Console.Clear();

            Console.WriteLine($"Primeiro valor inserido: {v1}");
            Console.WriteLine($"Segundo valor inserido: {v2}");

            var resultado = v1 - v2;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Resultado: {resultado}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Digite 1 para voltar ao Menu ou 2 para fechar o programa!");
            int.TryParse(Console.ReadLine(), out int fim);

            if (fim == 1) {
                Menu();
            }
            else {
                Console.WriteLine("Programa finalizado!!! Pressione qualquer tecla para fechar o programa.");
            }

            //switch (fim) {
            //    case 1:
            //        Console.Clear();
            //        Menu();
            //        break;
            //    default:
            //        Console.Clear();
            //        Console.WriteLine("Programa finalizado!!! Pressione qualquer tecla para fechar o programa.");
            //        break;
            //}
        }

        static void Divisao() {
            Console.WriteLine($"Você escolheu DIVISÃO!");
            Console.WriteLine("Insira o primeiro valor: ");
            int.TryParse(Console.ReadLine(), out int v1);
            Console.Clear();
            Console.WriteLine("Insira o segundo valor: ");
            int.TryParse(Console.ReadLine(), out int v2);
            Console.Clear();

            Console.WriteLine($"Primeiro valor inserido: {v1}");
            Console.WriteLine($"Segundo valor inserido: {v2}");

            var resultado = v1 / v2;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Resultado {resultado}");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Digite 1 para voltar ao Menu ou 2 para fechar o programa!");
            int.TryParse(Console.ReadLine(), out int fim);

            if (fim == 1) {
                Menu();
            }
            else {
                Console.WriteLine("Programa finalizado!!! Pressione qualquer tecla para fechar o programa.");
            }

            //switch (fim) {
            //    case 1:
            //        Console.Clear();
            //        Menu();
            //        break;
            //    default:
            //        Console.Clear();
            //        Console.WriteLine("Programa finalizado!!! Pressione qualquer tecla para fechar o programa.");
            //        break;
            //}
        }

        static void Multiplicacao() {
            Console.WriteLine($"Você escolheu MULTIPLICAÇÃO!");
            Console.WriteLine("Insira o primeiro valor: ");
            int.TryParse(Console.ReadLine(), out int v1);
            Console.Clear();
            Console.WriteLine("Insira o segundo valor: ");
            int.TryParse(Console.ReadLine(), out int v2);
            Console.Clear();

            Console.WriteLine($"Primeiro valor inserido: {v1}");
            Console.WriteLine($"Segundo valor inserido: {v2}");

            var resultado = v1 * v2;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Resultado {resultado}");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Digite 1 para voltar ao Menu ou 2 para fechar o programa!");
            int.TryParse(Console.ReadLine(), out int opcao);

            if (opcao == 1) {
                Menu();
            }
            if(opcao == 2 ) {
                Console.WriteLine("Programa finalizado!!! Pressione qualquer tecla para fechar o programa.");
                Thread.Sleep(2500);
                System.Environment.Exit(2);
            }

            //switch (fim) {
            //    case 1:
            //        Console.Clear();
            //        Menu();
            //        break;
            //    default:
            //        Console.Clear();
            //        Console.WriteLine("Programa finalizado!!! Pressione qualquer tecla para fechar o programa.");
            //        break;
            //}
        }

        static void Main(string[] args) {
            Menu();

        }
    }
}
