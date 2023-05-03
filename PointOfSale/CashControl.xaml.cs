using DinoDiner.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace DinoDiner.PointOfSale
{
    /// <summary>
    /// Interaction logic for CashControl.xaml
    /// </summary>
    public partial class CashControl : UserControl
    {
        public CashControl()
        {
            InitializeComponent();
            var window = Application.Current.MainWindow as DinoDiner.PointOfSale.MainWindow;
            var order = (Order)window.DataContext;
            this.DataContext = new CashViewModel(order);
        }

        /// <summary>
        /// Handles a click on "Return to Order" button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The event args</param>
        void OnReturnToOrderClick(object sender, RoutedEventArgs e)
        {
            var window = Application.Current.MainWindow as DinoDiner.PointOfSale.MainWindow;
            window.ContainerBorder.Child = null;
        }

        /// <summary>
        /// Handles a click on "Finalize Sale" button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The event args</param>
        void OnFinalizeSaleClick(object sender, RoutedEventArgs e)
        {
            var CashViewModel = (CashViewModel)DataContext;
            var window = Application.Current.MainWindow as DinoDiner.PointOfSale.MainWindow;
            CashViewModel.FinalizingTransaction();
            if (window.DataContext is Order order)
            {
                window.DataContext = new Order();
                this.DataContext = new CashViewModel(new Order());
                window.ContainerBorder.Child = null;
            }
        }
    }
}
