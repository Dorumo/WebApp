using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppVazio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //fui na base de dados, peguei os dados
            Models.Produto produto = new Models.Produto();
            produto.Id = Guid.NewGuid();
            produto.Nome = "Artur";

            return View(produto);
        }
        public IActionResult Index2(string nome, int id = 1)
        {
            ViewData["nome"] = nome;
            ViewData["id"] = id;
            var produtos = new List<Models.Produto>();

            Models.Produto produto = new Models.Produto();
            produto.Id = Guid.NewGuid();
            produto.Nome = "Artur";

            Models.Produto produto1 = new Models.Produto();
            produto1.Id = Guid.NewGuid();
            produto1.Nome = "Artur";

            Models.Produto produto2 = new Models.Produto();
            produto2.Id = Guid.NewGuid();
            produto2.Nome = "Artur";

            produtos.Add(produto);
            produtos.Add(produto1);
            produtos.Add(produto2);

            return View(produtos);
        }
    }
}
