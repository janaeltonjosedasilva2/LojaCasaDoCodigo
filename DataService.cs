using CasaDoCodigo.Models;
using CasaDoCodigo.Ropositories;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace CasaDoCodigo
{
    class DataService : IDataService
    {
        private readonly ApplicationContext context;
        private readonly IProdutoRepository produtoRepository;

        public DataService(ApplicationContext applicationContext, IProdutoRepository produtoRepository)
        {
            this.context = applicationContext;
            this.produtoRepository = produtoRepository;
        }

        public void InicializaDB()
        {
            context.Database.Migrate();
            List<Livros> livros = GetLivros();
            produtoRepository.SaveProdutos(livros);
        }

        private static List<Livros> GetLivros()
        {
            var json = File.ReadAllText("livros.json");
            var livros = JsonConvert.DeserializeObject<List<Livros>>(json);
            return livros;
        }
    }
}
