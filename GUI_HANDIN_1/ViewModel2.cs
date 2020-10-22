using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace GUI_HANDIN_1
{
    class ViewModel2:BindableBase
    {
        public ViewModel2()
        {
            Debtor=new Debtor("Name",0.0);
        }
        public Debtor Debtor { get; set; }
    }
}
