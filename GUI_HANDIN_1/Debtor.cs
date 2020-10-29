using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace GUI_HANDIN_1
{
    public class Debtor:BindableBase
    {
        public Debtor(String name)
        {
            debits=new ObservableCollection<Debit>();
            Name = name;
            
        }
        public String Name { get; set; }

        private ObservableCollection<Debit> debits;
        public ObservableCollection<Debit> Debits
        {
            get { return debits; }
            set { SetProperty(ref debits, value); }

        }

        private double totalDebt_;

        public double TotalDebt
        {
            get { return totalDebt_;}
            private set { SetProperty(ref totalDebt_, value); }
        }

        public void AddDebit(double value)
        {
            TotalDebt += value;
            Debits.Add(new Debit(value));
            
        }
    }
}
