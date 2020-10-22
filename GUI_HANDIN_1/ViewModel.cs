using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;

namespace GUI_HANDIN_1
{
    public class ViewModel : BindableBase
    {
        private ObservableCollection<Debtor> debtors;



        //Properties
        public ObservableCollection<Debtor> Debtors
        {
            get { return debtors;}
            set { SetProperty(ref debtors, value); }
        }

        private Debtor currentDebtor=null;
        public Debtor CurrentDebtor
        {
            get { return currentDebtor; }
            set { SetProperty(ref currentDebtor, value); }
        }

        private int currentIndex = -1;

        public int CurrentIndex { get {return currentIndex}
            set { SetProperty(ref currentIndex, value); }
        }   
        

        //Commands

        private ICommand _AddDebtorCommand;

        public ICommand AddDebtorCommand
        {
            get { return _AddDebtorCommand ?? (_AddDebtorCommand = new DelegateCommand<Debtor>(AddDebtor)); }
        }

        private void AddDebtor(Debtor obj)
        {
            Debtors.Add(obj);
        }
    }


    
}
