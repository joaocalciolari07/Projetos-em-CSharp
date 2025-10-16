using System;


namespace Ecommerce
{
    internal class Progam
    {
        static void Main (string[] args)
        {
            Models.Produto p1 = new Models.Produto(1 ,"Arroz" , "Commida" ,23);
            Models.Produto p2 = new Models.Produto(20 , "Tv" , "Eletronica",5600);
            Models.Produto p3 = new Models.Produto(51, "cachaca", "bebida", 9.5);

            p3.AplicarDesconto(150);

               
          

        }
    }
}   