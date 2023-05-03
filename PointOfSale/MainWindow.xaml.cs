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
using DinoDiner.Data.Sides;
using DinoDiner.Data.Enums;
using DinoDiner.Data.Entrees;
using DinoDiner.Data.Drinks;
using DinoDiner.Data;

namespace DinoDiner.PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new Order();

        }
        /// <summary>
        /// Shows the wanted screen in the main window
        /// </summary>
        /// <param name="screen">The screen to show</param>
        public void ShowScreen(UserControl screen)
        {
            ContainerBorder.Child = screen;
        }

        /// <summary>
        /// Handles going back to the main menu.
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The event args</param>
        private void BackToMainMenu(object sender, RoutedEventArgs e)
        {
            ContainerBorder.Child = null;
        }

        /// <summary>
        /// Handles a click on Cancel Order button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The event args</param>
        void OnCancelOrderClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                this.DataContext = new Order();
                ContainerBorder.Child = null;

            }
        }
        /// <summary>
        /// Handles a click on Complete Order button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The event args</param>
        void OnCompleteOrderClick(object sender, RoutedEventArgs e)
        {
            var paymentControl = new PaymentControl();
            ShowScreen(paymentControl);
        }

    }
}
