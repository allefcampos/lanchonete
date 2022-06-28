using Lanchonete.Models;
using System.Collections.Generic;

namespace Lanchonete.Repositories
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }
        Lanche GetByLancheId(int lancheId);

    }
}
