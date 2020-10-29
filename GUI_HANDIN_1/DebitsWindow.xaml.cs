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
using Prism.Commands;

namespace GUI_HANDIN_1
{
    /// <summary>
    /// Interaction logic for DebitsWindow.xaml
    /// </summary>
    public partial class DebitsWindow : Window
    {
        public DebitViewModel ViewModel;
        public DebitsWindow(Debtor debtor)
        {
            InitializeComponent();
            ViewModel = new DebitViewModel();
            this.DataContext = ViewModel;
            ViewModel.Debtor = debtor;
            ViewModel.Window = this;
        }
    }
}
