using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPraticoAED
{
    class Program
    {

        static void Main(string[] args)
        {
            #region atributos
            string usuario;
            string senha;

            #endregion

            Console.WriteLine("informe seu usuario");
            usuario = Console.ReadLine();
            Console.WriteLine("Informe a sua senha");
            senha = Console.ReadLine();

            int op = 0, sair = 1;
            Console.Clear();
            Carrinho carrinho = new Carrinho("Compras", "Todo tipo de livro que tiver");
            Livro livros = new Livro();
            Lista listalivros = new Lista();
            livros.adicionaLivros(listalivros);
            Carrinho c = new Carrinho();
            do
            {
                Console.Clear();
                Console.WriteLine("Escolha o que deseja fazer!" +
                    "\n1 - Listar os livros" +
                    "\n2 - Adicionar livro do carrinho de compras" +
                    "\n3 - Excluir livro do carrinho de compras" +
                    "\n4 - Ver Carrinho de compras" +
                    "\n5 - Ordenar Carrinho por Preço." +
                    "\n6 - Finalizar compra" +
                    "\n0 - Sair");
                op = int.Parse(Console.ReadLine());
                switch (op) {
                    case 1:
                        Console.Clear();
                        listalivros.imprimir();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Digite o código do livro desejado: ");
                        int codigo = int.Parse(Console.ReadLine());
                        Console.Write("Digite a quantidade desse livro que deseja adicionar ao carrinho: ");
                        int quantidade = int.Parse(Console.ReadLine());
                        if (listalivros.localizar(codigo) != null && codigo < 25)
                        {
                            listalivros.adicionar(listalivros.localizar(codigo).Livro);
                            listalivros.localizar(codigo).Livro.aumentarquant(quantidade);
                            Console.Write("Livro adicionado com sucesso!!");
                        }
                        else { Console.WriteLine("Livro não existe!!"); }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Digite o código do livro que deseja remover: ");
                        codigo = int.Parse(Console.ReadLine());
                        Console.Write("Digite a quantidade que deseja remover: ");
                        quantidade = int.Parse(Console.ReadLine());

                        if (quantidade >= listalivros.localizar(codigo).Livro.getquant())
                        {
                            listalivros.localizar(codigo).Livro.diminuirquant(quantidade);
                            listalivros.remover(codigo);
                        }
                        else
                        {
                            Console.WriteLine("Erro ao excluir livro!");
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Carrinho: ");
                        c.getCarrinho().imprimirComQtd();
                        Console.ReadKey();
                        
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("1-Crescente.\n2-Decrescente.\nDigite o numero da ordenação você deseja: ");
                        int ordena = int.Parse(Console.ReadLine());
                        if (ordena == 1)
                        {
                            listalivros.getListaLivro().ordenarCrescente();
                            listalivros.getListaLivro().imprimirComQtd();
                            Console.ReadKey();
                        }
                        else if (ordena == 2)
                        {
                            listalivros.getListaLivro().ordenarDecrescente();
                            listalivros.getListaLivro().imprimirComQtd();
                            Console.ReadKey();
                        }
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        
                        char a;
                        listalivros.getListaLivro().imprimirComQtd();
                        Console.WriteLine("Preço total = {0}.", listalivros.getListaLivro().somaPreço().ToString());
                        Console.WriteLine("Pressione f para finalizar o pedido ou outra tecla para voltar as compras");
                        a = char.Parse(Console.ReadLine());
                        if (a == 'f' || a == 'F')
                        {
                            Console.WriteLine("Informe o numero do cartão de crédito.");
                            string numero = Console.ReadLine();
                            Console.WriteLine("Compra Finalizada com sucesso!!!\nTecle Enter para voltar ao menu.");
                        }
                        Console.ReadKey();
                        break;
                    case 0:
                        sair = 0;
                        break;
                }
            } while (sair == 1);
        }
    }
}
