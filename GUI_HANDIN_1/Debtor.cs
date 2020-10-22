using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_HANDIN_1
{
    public class Debtor
    {
        public String Name { get; set; }

        public List<Debit> Debits { get; }

        public double TotalDebt { get; private set; }

        public void AddDebit(double value)
        {
            TotalDebt += value;
            Debits.Add(new Debit(value));
        }
    }
}
