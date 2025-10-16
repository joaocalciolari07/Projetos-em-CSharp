class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("Hello word");
    } 
    public Pessoa(string nome)
    {
        Console.WriteLine($"Ola {nome}");   
    }    
    public Pessoa(string nome , int idade)
    {
        Console.WriteLine($"ola {nome} com a idade {idade}");
    } 
}