using Lanchonete.Models;
using System.Collections.Generic;

namespace Lanchonete.Repositories
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
