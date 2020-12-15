using System;

namespace Ex2.classes
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }

        public Produto(){
            
        }
        
        public Produto(int codigo, string nome, string desc, int estoque){
            if (codigo <0){
                Console.WriteLine("Valor Inválido");
            }else{
                Codigo = codigo;
            Nome = nome;
            Descricao = desc;
            Estoque = estoque;

            Console.WriteLine($"Produto cadastrado Código - {Codigo} - Nome {Nome}");
                        
            }
        }// fim construtor

        public Produto (int codigo){
            if (codigo >= 0){
                    Codigo = codigo;
                    Nome = "Pepsi";
                    Console.WriteLine($"Produto cadastrado Código - {Codigo} - Nome {Nome ?? "Sem nome"}");
            }else{
                Console.WriteLine("Código inválido");
            }
        }

    }
}