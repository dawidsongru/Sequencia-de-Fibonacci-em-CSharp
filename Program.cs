// Sequência de Fibonacci
// Este aplicativo exibe se o número digitado pertence a sequência de Fibonacci.
// A sequência de Fibonacci é uma sequência de números onde cada número é a soma dos dois números anteriores.
// Os primeiros termos da sequência de Fibonacci são 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ...
// Versão: 1.0
// Autor: Dawidson Pereira Gaião
// Data: 12/03/2024

using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe um número para verificar se pertence à sequência de Fibonacci: ");

        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (VerificarFibonacci(numero))
            {
                Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
            }
        }
        else
        {
            Console.WriteLine("Por favor, insira um número válido.");
        }
    }

    static bool VerificarFibonacci(int num)
    {
        if (num < 0)
        {
            return false;
        }

        int a = 0, b = 1;

        while (a <= num)
        {
            if (a == num)
            {
                return true;
            }

            int temp = a;
            a = b;
            b = temp + b;
        }

        return false;
    }
}
