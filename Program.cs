using System;
using Ex2.classes;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto(10, "X-Tudo", "Lanche com tudo", 10);
            
            Produto produto2 = new Produto(10);

            Produto produto3 = new Produto();
            
            produto3.Nome = "Coca-Cola";
            produto3.Descricao = "Refrigerante de Cola";

        }
    }
}
