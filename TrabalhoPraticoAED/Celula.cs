using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPraticoAED
{
    class Celula
    {
        #region atributos
        public Livro Livro { get; set; }
        public Celula Prox { get; set; }
        public Celula(Livro livro)
        {
            this.Livro = livro;
        }
        #endregion
    }
}
