using Lanchonete.Models;
using Lanchonete.Repositories;
using Lanchonete.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lanchonete.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List(string categoria)
        {
            //var lanches = _lancheRepository.Lanches;
            //return View(lanches);

            string _categoria = categoria;
            IEnumerable<Lanche> lanches;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                lanches = _lancheRepository.Lanches.OrderBy(p => p.LancheId);
                categoriaAtual = "Todos os lanches";
            }
            else
            {
                if (string.Equals("Normal", _categoria, StringComparison.OrdinalIgnoreCase))
                    lanches = _lancheRepository.Lanches.Where(p => p.Categoria.CategoriaNome.Equals("Normal")).OrderBy(p => p.Nome);
                else
                    lanches = _lancheRepository.Lanches.Where(p => p.Categoria.CategoriaNome.Equals("Natural")).OrderBy(p => p.Nome);

                categoriaAtual = _categoria;
                
            }

            var lancheListViewModel = new LancheListViewModel
            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual
            };

            return View(lancheListViewModel);
        }

        public ViewResult Details(int lancheId)
        {
            var lanche = _lancheRepository.Lanches.FirstOrDefault(d => d.LancheId == lancheId);
            if (lanche == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
            return View(lanche);
        }
    }
}
