using System; 

namespace Ecommerce.Models
{
    internal class Produto
    {
        private static int contador = 0; //Nao tem referencia com o objeto (alocado uma unica vez - classe)
        public int Id { get; }
        public string Nome { get; set; } 
        public string Categoria { get; set; } 
        public double Preco { get; private set; }

        public Produto(int id , string nome , string categoria ,double preco)
        {
            Id = ++contador ;
            Nome = nome;
            Categoria = categoria;
            Preco = preco;
        }
        public void AplicarDesconto(double percentualDesconto)
        {
            if (!(percentualDesconto >= 0 && percentualDesconto <= 100))
                throw new ArgumentException("erro no percentual de desconto ,menor ou igual a zero");  
            
            this.Preco = this.Preco * ( 1 - (percentualDesconto / 100)); 
        }  
        public void AumentarPreco (double percentualAumento)
        {
            if (percentualAumento <= 0)
                throw new ArgumentException("erro no percentual de aumento ,menor ou igual a zero");  

            this.Preco = this.Preco * (1 + (percentualAumento / 100));      
        }      

    }
     
}      

