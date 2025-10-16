using System;

class Program   
{
    static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();

        Console.WriteLine("=== Calculadora ===");
        Console.Write("Digite o primeiro número: ");
        double a = double.Parse(Console.ReadLine()!);

        Console.Write("Digite o segundo número: ");
        double b = double.Parse(Console.ReadLine()!);   

        Console.WriteLine("\nResultados:");
        Console.WriteLine($"Soma: {calc.Soma(a, b)}");
        Console.WriteLine($"Subtração: {calc.Subtracao(a, b)}");
        Console.WriteLine($"Multiplicação: {calc.Mutiplicacao(a, b)}");
        Console.WriteLine($"Divisão: {calc.Divisao(a, b)}");

        Console.WriteLine("\nFunções avançadas (ângulo em radianos):");
        Console.WriteLine($"Seno({a}): {calc.Seno(a)}");
        Console.WriteLine($"Cosseno({a}): {calc.Cosseno(a)}");
        Console.WriteLine($"Tangente({a}): {calc.Tangente(a)}");

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
