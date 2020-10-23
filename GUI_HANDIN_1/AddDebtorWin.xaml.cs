using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GUI_HANDIN_1
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class AddDebtorWin : Window
    {
        
        public AddDebtorWin()
        {
            InitializeComponent();
            ViewModel=DataContext as ViewModel2;
            if (ViewModel.CloseAction == null)
                ViewModel.CloseAction = new Action(this.Close);
        }
        public ViewModel2 ViewModel { get; private set; }

    }

    public class DebtorEventArgs : EventArgs
    {
        public Debtor Debtor;
    }
}
