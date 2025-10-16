using System;

namespace Ecommerce.Models
{
    public class Cliente
    {
        // Campo estático: conta quantos clientes foram criados
        private static int contador = 0;

        // Propriedades automáticas
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    

    }  
}
