using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_HANDIN_1
{
    public class Debit
    {
        public Debit(double value)
        {
            Value = value;
            AddedDate = DateTime.Now;
        }
        public double Value { get; }

        public DateTime AddedDate { get; }
    }
}
