using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPraticoAED
{
    class Lista
    {
        private Celula primeiro;
        private Celula ultimo;
        Lista listaLivros = new Lista();

        public Lista()
        {
            primeiro = new Celula(null);
            ultimo = primeiro;
        }
        public void imprimir()
        {
            Celula aux = primeiro;
            while (aux.Prox != null)
            {
                Console.WriteLine("Código:{0}   Nome:{1}     Autor:{2}    Preço:{3}", aux.Prox.Livro.getCodigo(), aux.Prox.Livro.getNome(), aux.Prox.Livro.getAutor(), aux.Prox.Livro.getValor());
                aux = aux.Prox;
            }

        }
        public void adicionar(Livro liv)
        {
            if (!ehVazia())
            {
                ultimo.Prox = new Celula(liv);
                ultimo = ultimo.Prox;
                ultimo.Prox = null;
            }
            else
            {
                primeiro.Prox = new Celula(liv);
                ultimo = primeiro.Prox;
                ultimo.Prox = null;
            }
        }
        public Boolean ehVazia()
        {
            if (primeiro.Prox == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void remover(int chave)
        {
            Celula aux = primeiro;
            if (!ehVazia())
            {
                while (aux.Prox != null)
                {
                    if (aux.Prox.Livro.getCodigo() == chave)
                    {
                        Celula q = aux.Prox;
                        aux.Prox.Livro = null;
                        aux.Prox = q.Prox;
                    }
                    else
                    {
                        aux = aux.Prox;
                    }
                }
            }

        }
        public Celula localizar(int chave)
        {
            Celula aux = primeiro;
            while (aux.Prox != null)
            {
                if (aux.Prox.Livro.getCodigo() == chave)
                {
                    return aux.Prox;
                }
                aux = aux.Prox;
            }
            return null;
        }
        public void imprimirComQtd()
        {
            Celula aux = primeiro;
            while (aux.Prox != null)
            {
                Console.WriteLine("Código:{0} Nome:{1}.\tAutor:{2}.\tPreço:{3}.\tQuant: {4}", aux.Prox.Livro.getCodigo(), aux.Prox.Livro.getNome(), aux.Prox.Livro.getAutor(), aux.Prox.Livro.getValor(), aux.Prox.Livro.getquant());
                aux = aux.Prox;
            }

        }
        public double somaPreço()
        {
            double preço = 0;
            Celula aux = primeiro;
            while (aux.Prox != null)
            {
                preço += aux.Prox.Livro.getValor() * aux.Prox.Livro.getquant();
                aux = aux.Prox;
            }
            return preço;

        }
        public void ordenarCrescente()
        {
            Celula aux = primeiro;
            Celula aux2 = primeiro.Prox;
            while (aux.Prox != null)
            {
                aux2 = aux.Prox;
                while (aux2.Prox != null)
                {
                    if (aux.Prox.Livro.getValor() > aux2.Prox.Livro.getValor())
                    {
                        Livro auxiliar = aux.Prox.Livro;
                        aux.Prox.Livro = aux2.Prox.Livro;
                        aux2.Prox.Livro = auxiliar;

                    }
                    aux2 = aux2.Prox;
                }
                aux = aux.Prox;
            }
        }
        public void ordenarDecrescente()
        {
            Celula aux = primeiro;
            Celula aux2 = primeiro.Prox;
            while (aux.Prox != null)
            {
                aux2 = aux.Prox;
                while (aux2.Prox != null)
                {
                    if (aux.Prox.Livro.getValor() < aux2.Prox.Livro.getValor())
                    {
                        Livro auxiliar = aux.Prox.Livro;
                        aux.Prox.Livro = aux2.Prox.Livro;
                        aux2.Prox.Livro = auxiliar;

                    }
                    aux2 = aux2.Prox;
                }
                aux = aux.Prox;
            }
        }


        public Lista getListaLivro()
        {
            return listaLivros;
        }
    }
}
