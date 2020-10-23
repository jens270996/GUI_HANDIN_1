using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;

namespace GUI_HANDIN_1
{
    public class ViewModel2:BindableBase
    {
        public ViewModel2()
        {
            Debtor=new Debtor("Name",0.0);
            initialDebt = 0.0;
        }

        public double InitialDebt { get { return initialDebt; } set { SetProperty(ref initialDebt, value); } }
        private double initialDebt;
        public Debtor Debtor { get; set; }


        private ICommand _AddDebtorAndCloseCommand;

        public ICommand AddDebtorAndCloseCommand
        {
            get { return _AddDebtorAndCloseCommand ?? (_AddDebtorAndCloseCommand = new DelegateCommand(AddDebtorAndClose)); }
        }

        private void AddDebtorAndClose()
        {
            Debtor.AddDebit(initialDebt);
            var args = new DebtorEventArgs();
            args.Debtor = Debtor;
            DebtorAddedEvent?.Invoke(this, args);
            CloseAction();
        }
            public event EventHandler<DebtorEventArgs> DebtorAddedEvent;
            public Action CloseAction { get; set; }

    }
    
}
