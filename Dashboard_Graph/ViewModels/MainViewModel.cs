using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Dashboard_Graph.ViewModels
{
    class MainViewModel : ViewModelBase
    {

        //-> Commands
        public ICommand? ShowHomeViewCommand { get; }
        public ICommand? ShowCustomerViewCommand { get; }
    }
}
