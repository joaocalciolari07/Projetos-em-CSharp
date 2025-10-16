class Colaborador :  Pessoa
{
   //Atributos
   private string?_cargo;

   private double _salario;  

   //Construtor
   public Colaborador(string nome ,int idade , string cargo , double salario) : base(nome ,  idade)
   {
    _cargo = cargo;
    _salario = salario;
    ApresentarColaborador();
    ApresentarPessoa();
   }
   //Metodo Para apresentar dados

   private void ApresentarColaborador()
   {
    Console.WriteLine($"Cargo : {_cargo}");
    Console.WriteLine($"Salario : {_salario}");
   }
}