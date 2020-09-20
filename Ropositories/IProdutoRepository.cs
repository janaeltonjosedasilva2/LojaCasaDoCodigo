using CasaDoCodigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Ropositories
{
    public interface IProdutoRepository
    {
        void SaveProdutos(List<Livros> livros);
        IList<Produto> GetProdutos();
    }
}
