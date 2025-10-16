using System;

class Program
{
    static void Main()
    {
        IFuncionario funcionario = new Funcionario("João", 3000);
        

        Console.Write("Percentual de reajuste: ");
        string? entrada = Console.ReadLine();

        if (double.TryParse(entrada, out double percentual))
        {
            funcionario.ReajustarSalario(percentual);
            Console.WriteLine($"Novo salário: R$ {funcionario.Salario:F2}");
        }
        else
        {
            Console.WriteLine("Valor inválido. Digite um número válido.");
        }
    }
}
