using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPraticoAED
{
    class Livro
    {
        #region atributos

        private int codigo { get; set; }
        private string nome;
        private string autor;
        private double valor;
        private int quantidade;
        List<Livro> livros = new List<Livro>();

        #endregion
        #region preenchendo tabela

        public void adicionaLivros(Lista listalivros)
        {
            listalivros.adicionar(new Livro(1, "Projeto de Algoritmos", "Nívio Ziviani", 76.50));
            listalivros.adicionar(new Livro(2, "Design de Interação", "Jenny Preece", 67.80));
            listalivros.adicionar(new Livro(3, "Data Structure and Algorithms", "Alfred Aho", 123.00));
            listalivros.adicionar(new Livro(4, "Semiotic Engineering for HCI", "Clarisse de Souza", 80.00));
            listalivros.adicionar(new Livro(5, "Algoritmos e Estruturas de Dados", "Ângelo Guimarães", 40.00));
            listalivros.adicionar(new Livro(6, "Cálculo Numérico", "Leônidas Barroso", 55.00));
            listalivros.adicionar(new Livro(7, "Introdução à Computação Móvel", "Geraldo Mateus", 40.00));
            listalivros.adicionar(new Livro(8, "Modern Information Retrieval", "Berthier Ribeiro", 55.00));
            listalivros.adicionar(new Livro(9, "Sistemas de Comércio Eletrônico", "Wagner Meira", 40.00));
            listalivros.adicionar(new Livro(10, "Introdução à Ciência da Computação", "Ângelo Guimarães", 45.00));
            listalivros.adicionar(new Livro(11, "Alice no País das Maravilhas", "Lewis Carroll", 30.90));
            listalivros.adicionar(new Livro(12, "A Arte da Política – A História que Vivi", "Fernando Henrique Cardoso", 70.00));
            listalivros.adicionar(new Livro(13, "As Intermitências da Morte", "José Saramago", 35.00));
            listalivros.adicionar(new Livro(14, "A Bagagem do Viajante", "José Saramago", 35.00));
            listalivros.adicionar(new Livro(15, "O Nome da Rosa", "Umberto Eco", 55.00));
            listalivros.adicionar(new Livro(16, "Vidas Secas", "Graciliano Ramos", 27.90));
            listalivros.adicionar(new Livro(17, "Grande Sertão Veredas", "João Guimarães Rosa", 28.00));
            listalivros.adicionar(new Livro(18, "Capitães de Areia", "Jorge Amado", 30.90));
            listalivros.adicionar(new Livro(19, "O Retorno do Chef Sem Mistérios", "Jamie Oliver", 69.00));
            listalivros.adicionar(new Livro(20, "1000 Receitas da Culinária Brasileira", "Regina Reis", 49.00));
            listalivros.adicionar(new Livro(21, "Le Cordon Bleu – Todas as Técnicas da Culinária", "Jeni Wright", 220.00));
            listalivros.adicionar(new Livro(22, "O que Einstein Disse a seu Cozinheiro", "Robert L.Wolke", 41.00));
            listalivros.adicionar(new Livro(23, "Guia dos Vinhos Brasileiros", "Eduardo Viotti", 55.00));
            listalivros.adicionar(new Livro(24, "Saladas: Celeiro", "Maria Rosa Herz", 90.00));

        }


        #endregion
        public Livro() { }
        public Livro(int codigo, string nome, string autor, double valor)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.autor = autor;
            this.valor = valor;


        }

        #region get e set
        public int getCodigo()
        {
            return this.codigo;
        }
        public string getNome()
        {
            return this.nome;
        }
        public string getAutor()
        {
            return this.autor;
        }
        public double getValor()
        {
            return this.valor;
        }
        public int getquant()
        {
            return this.quantidade;
        }
        public void aumentarquant(int quant)
        {
            quantidade += quant;
        }
        public void diminuirquant(int quant) {
            quantidade -= quant;
        }
        #endregion
    }

}
