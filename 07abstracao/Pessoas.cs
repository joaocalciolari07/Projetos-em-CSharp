

using System.Runtime.CompilerServices;

class Pessoa : Acoes
{
    public override void Andar() 
    {
        Console.WriteLine("estou andando ...");
    }

    public override void Falar()
    {
       Console.WriteLine("estou falando ...");
    }
} 