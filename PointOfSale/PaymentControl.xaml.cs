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
using RoundRegister;

namespace DinoDiner.PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentControl.xaml
    /// </summary>
    public partial class PaymentControl : UserControl
    {
        public PaymentControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles a click on "Credit/Debit" button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The event args</param>
        void OnCreditDebitClick(object sender, RoutedEventArgs e)
        {
            var window = Application.Current.MainWindow as DinoDiner.PointOfSale.MainWindow;
            if (window.DataContext is Order order)
            {
                var result = CardReader.RunCard();
                if (result == CardTransactionResult.Approved)
                {
                    MessageBox.Show("Approved");
                    PrintReceipt(order);
                    window.DataContext = new Order();
                    window.ContainerBorder.Child = null;
                }
                else if (result == CardTransactionResult.Declined)
                {
                    MessageBox.Show("Credit/Debit card is Declined");
                }
                else if (result == CardTransactionResult.ReadError)
                {
                    MessageBox.Show("Error occurred. Try again");
                }
                else if (result == CardTransactionResult.InsufficientFunds)
                {
                    MessageBox.Show("Insufficient funds in Credit/Debit card");
                }
                else if (result == CardTransactionResult.IncorrectPin)
                {
                    MessageBox.Show("The pin you entered is incorrect");
                }
            }
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
        /// Handles a click on "Cash" button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The event args</param>
        void OnCashClick(object sender, RoutedEventArgs e)
        {
            var window = Application.Current.MainWindow as DinoDiner.PointOfSale.MainWindow;
            var CashControl = new CashControl();
            window.ShowScreen(CashControl);
        }

        /// <summary>
        /// Prints the receipt of the order. 
        /// </summary>
        /// <param name="order">The order to print the receipt for</param>
        public void PrintReceipt(Order order)
        {
            ReceiptPrinter.PrintLine($"Order # {order.Number.ToString()}");
            ReceiptPrinter.PrintLine(order.PlacedAt.ToString());
            ReceiptPrinter.PrintLine("");
            foreach (IMenuItem item in order)
            {
                ReceiptPrinter.PrintLine($"{AbbreviatedOrderName(item).PadRight(35)}${item.Price.ToString()}");
                if (item.SpecialInstructions != null)
                {
                    foreach (string special in item.SpecialInstructions)
                    {
                        ReceiptPrinter.PrintLine(special);
                    }
                }
            }
            ReceiptPrinter.PrintLine("");
            ReceiptPrinter.PrintLine($"Subtotal: ${order.Subtotal.ToString()}");
            ReceiptPrinter.PrintLine($"Tax: ${order.Tax.ToString()}");
            ReceiptPrinter.PrintLine($"Total: ${order.Total.ToString()}");
            ReceiptPrinter.PrintLine("Payment method: Card");
            ReceiptPrinter.PrintLine("Change owed: 0");
            ReceiptPrinter.CutTape();
        }

        /// <summary>
        /// The abbreviated order name to fit in the receipt.
        /// </summary>
        /// <param name="item">The item to abbreviated</param>
        /// <returns>The abbreviated name of the item </returns>
        private string AbbreviatedOrderName(IMenuItem item)
        {
            if (item.Name == "Allosaurus All-American") return "Allosaurus All-American Burger";
            else if (item.Name == "Carnotaurus Cheeseburger") return "Carnotaurus Cheeseburger";
            else if (item.Name == "Deinonychus Double") return "Deinonychus Double Burger";
            else if (item.Name == "T-Rex Triple Burger") return "T-Rex Triple Burger";
            else if (item.Name == "Large Cola Plilosoda") return "Lg Cola Plilosoda";
            else if (item.Name == "Medium Cola Plilosoda") return "Md Cola Plilosoda";
            else if (item.Name == "Small Cola Plilosoda") return "Sm Cola Plilosoda";
            else if (item.Name == "Large Cherry Cola Plilosoda") return "Lg Cherry Cola Plilosoda";
            else if (item.Name == "Medium Cherry Cola Plilosoda") return "Md Cherry Cola Plilosoda";
            else if (item.Name == "Small Cherry Cola Plilosoda") return "Sm Cherry Cola Plilosoda";
            else if (item.Name == "Large Doctor Dino Plilosoda") return "Lg Doctor Dino Plilosoda";
            else if (item.Name == "Medium Doctor Dino Plilosoda") return "Md Doctor Dino Plilosoda";
            else if (item.Name == "Small Doctor Dino Plilosoda") return "Sm Doctor Dino Plilosoda";
            else if (item.Name == "Large Lemon-Lime Plilosoda") return "Lg Lemon-Lime Plilosoda";
            else if (item.Name == "Medium Lemon-Lime Plilosoda") return "Md Lemon-Lime Plilosoda";
            else if (item.Name == "Small Lemon-Lime Plilosoda") return "Sm Lemon-Lime Plilosoda";
            else if (item.Name == "Large Dino Dew Plilosoda") return "Lg Dino Dew Plilosoda";
            else if (item.Name == "Medium Dino Dew Plilosoda") return "Md Dino Dew Plilosoda";
            else if (item.Name == "Small Dino Dew Plilosoda") return "Sm Dino Dew Plilosoda";
            else if (item.Name == "Large Fryceritops") return "Lg Fryceritops";
            else if (item.Name == "Medium Fryceritops") return "Md Fryceritops";
            else if (item.Name == "Small Fryceritops") return "Sm Fryceritops";
            else if (item.Name == "Large Meteor Mac & Cheese") return "Lg Meteor Mac & Cheese";
            else if (item.Name == "Medium Meteor Mac & Cheese") return "Md Meteor Mac & Cheese";
            else if (item.Name == "Small Meteor Mac & Cheese") return "Sm Meteor Mac & Cheese";
            else if (item.Name == "Large Mezzorella Sticks") return "Lg Mezzorella Sticks";
            else if (item.Name == "Medium Mezzorella Sticks") return "Md Mezzorella Sticks";
            else if (item.Name == "Small Mezzorella Sticks") return "Sm Mezzorella Sticks";
            else if (item.Name == "Large Triceritots") return "Lg Triceritots";
            else if (item.Name == "Medium Triceritots") return "Md Triceritots";
            else if (item.Name == "Small Triceritots") return "Sm Triceritots";
            else if (item.Name == "Brontowurst") return "Brontowurst";
            else if (item.Name == "Prehistoric PBJ") return "Prehistoric PBJ";
            else if (item.Name == "Buffalo Pterodactyl") return "Buffalo Pterodactyl";
            else if (item.Name == "Teriyaki Pterodactyl") return "Teriyaki Pterodactyl";
            else if (item.Name == "Honey Glaze Pterodactyl") return "Honey Glaze Pterodactyl";
            else if (item.Name == "Veloci-Wraptor") return "Veloci Wraptor";
            else if (item.Name == "6 Dino Nuggets") return "6pc Dino Nuggets";
            else return item.Name;
        }
    }
}
