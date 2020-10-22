using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_HANDIN_1
{
    public class Debtor
    {
        public Debtor(String name, double initialDebt)
        {
            debits=new List<Debit>();
            Name = name;
            AddDebit(initialDebt);
        }
        public String Name { get; set; }

        private List<Debit> debits;
        public List<Debit> Debits
        {
            get { return debits; }
        }

        public double TotalDebt { get; private set; }

        public void AddDebit(double value)
        {
            TotalDebt += value;
            Debits.Add(new Debit(value));
        }
    }
}
