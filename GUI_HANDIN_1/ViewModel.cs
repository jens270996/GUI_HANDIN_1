using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;

namespace GUI_HANDIN_1
{
    public class ViewModel : BindableBase
    {
        private ObservableCollection<Debtor> debtors;

        public ViewModel()
        {
            debtors=new ObservableCollection<Debtor>();
            debtors.Add(new Debtor("Jens",27.9));
            debtors.Add(new Debtor("Joachim",27000.0));
            //skriv op til event
            
            
        }


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

        public int CurrentIndex
        {
            get { return currentIndex;}
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
            AddDebtorWin win = new AddDebtorWin();
            
            win.Show();
            win.ViewModel.DebtorAddedEvent += HandleDebtorAddedEvent;
        }
        private ICommand _DebtorSelectedCommand;

        public ICommand DebtorSelectedCommand
        {
            get { return _DebtorSelectedCommand ?? (_DebtorSelectedCommand= new DelegateCommand(DebtorSelected)); }
        }

        private void DebtorSelected()
        {
            var win=new DebitsWindow();
            win.ViewModel.Debtor = CurrentDebtor;
            win.Show();
        }

       

        private void HandleDebtorAddedEvent(object sender, DebtorEventArgs e)
        {
            Debtors.Add(e.Debtor);
            
        }
       
    }


    
}
