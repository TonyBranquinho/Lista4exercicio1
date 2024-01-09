using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Digite um valor inteiro.");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
