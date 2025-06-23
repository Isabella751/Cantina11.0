using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_11._0
{
    internal class Carrinho
    {
        private List<Produto> itens = new List<Produto>();
        public double Total() => itens.Sum(p => p.Preco);
        public List<Produto> Listar() => new List<Produto>(itens);
    }
}
