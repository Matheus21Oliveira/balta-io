using System; 

namespace Calculator {
    class Program {
        static void Main(string[] args) {
          multiplicacao();
        }

        static void menu() {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");

            Console.WriteLine("Selecione uma opção: ");

            short resultado = short.Parse(Console.ReadLine());
        }
        static void soma() {
            Console.Clear();
            
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            
        } 

        static void subtracao() {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");

        }

        static void divisao() {
             Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
        }

        static void multiplicacao() {
             Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
        } 
    }
} 

