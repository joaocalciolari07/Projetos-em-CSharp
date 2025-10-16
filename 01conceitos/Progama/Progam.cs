//Exemplo 01
Pessoa obj1 = new Pessoa();
obj1.Nome =  "ralf";
//obj1.Apresentacao(); 

//Exemplo 02
Pessoa obj2 = new();
obj2.Nome = "Stella";
//obj2.Apresentacao();  

//Exemplo 03  
Pessoa obj3 = new()
{
   Nome = "Ricardo",
   Idade = 38
};  
string retorno = obj3.VerificarIdade();
Console.WriteLine(retorno);