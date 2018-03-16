using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPraticoAED
{
    public class Carrinho
    {
        #region atributos
        private Carrinho carrinho;
        private string nome;
        private string descriçao;
        Lista listaLivros = new Lista();
        #endregion

        public Carrinho() { }
        public Carrinho(string nome, string descriçao)
        {
            this.nome = nome;
            this.descriçao = descriçao;
        }
        public Carrinho getCarrinho()
        {
            return this.carrinho;
        }
        public void setCarrinho(Carrinho carrinho)
        {
            this.carrinho = carrinho;
        }

        internal void imprimirComQtd()
        {
            Lista lista = new Lista();
            lista.imprimirComQtd();
        }
       

    }
}
