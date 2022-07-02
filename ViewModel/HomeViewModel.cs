using Lanchonete.Models;
using System.Collections.Generic;

namespace Lanchonete.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<Lanche> LanchesPreferidos { get; set; }
    }
}
