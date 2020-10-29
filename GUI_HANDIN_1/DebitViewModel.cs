using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;

namespace GUI_HANDIN_1
{
    public class DebitViewModel:BindableBase
    {
        public Debtor Debtor { get; set; }
        
        public Window Window { get; set; }

        private ICommand _CloseCommand;
        public ICommand CloseCommand
        {
            get { return _CloseCommand ?? (_CloseCommand = new DelegateCommand(CloseWindow)); }
        }

        private void CloseWindow()
        {
            Window.Close();
        }

        private ICommand _AddDebitCommand;
        public ICommand AddDebitCommand
        {
            get { return _AddDebitCommand ?? (_AddDebitCommand = new DelegateCommand(AddDebit)); }
        }

        private void AddDebit()
        {
            Debtor.AddDebit(DebitValue);
            DebitValue = 0.0;
        }
        private double debitValue_=0.0;

        public double DebitValue
        {
            get { return debitValue_; }
            set { SetProperty(ref debitValue_, value); }
        }
    }
}
