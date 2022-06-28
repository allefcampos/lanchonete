using Lanchonete.Context;
using Lanchonete.Models;
using System.Collections.Generic;

namespace Lanchonete.Repositories.impl
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
