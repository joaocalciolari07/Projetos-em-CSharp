class Pessoa
{
    //Atributos
    public string? Nome;
    public int Idade;

    //Metodo de Apresentação 
    public void Apresentacao()
    {
        Console.WriteLine($"Ola meu nome é {Nome}");
    }   
    //Metodo para retornar a situação da idade 
    public string VerificarIdade()
    {
        return Idade >= 18 ? "Maior de Idade" : "Menor de idade" ;

    }
} 