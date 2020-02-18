using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel.Model;

namespace ViewModel.ViewModel
{
    public class ViewModelGames
    {
        public IEnumerable<PCGame> PCGames { get; set; }
        public IEnumerable<XBoxGame> XBoxGames { get; set; }
    }
}
