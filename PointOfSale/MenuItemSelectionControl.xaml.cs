using DinoDiner.Data.Entrees;
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
using DinoDiner.Data.Entrees;
using DinoDiner.Data.Enums;
using DinoDiner.Data.Drinks;
using DinoDiner.Data.Sides;
using DinoDiner.Data;

namespace DinoDiner.PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Handles a click on Allosaurus All AmericanBurger Button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The event args</param>
        void OnAllosaurusAllAmericanButtonClick(object sender, RoutedEventArgs e)
        {
            var burger = new AllosaurusAllAmericanBurger();
            var screen = new AllosaurusAllAmericanBurgerCustomizationControl();
            screen.DataContext = burger;
            var window = Application.Current.MainWindow as DinoDiner.PointOfSale.MainWindow;
            window.ShowScreen(screen);
            Order order = (Order)window.DataContext;
            order.Add(burger);
        }

        /// <summary>
        /// Handles a click on Carnotaurus Cheeseburger Button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The event args</param>
        void OnCarnotaurusCheeseburgerButtonClick(object sender, RoutedEventArgs e)
        {
            var burger = new CarnotaurusCheeseburger();
            var screen = new CarnotaurusCheeseburgerCustomizationControl();
            screen.DataContext = burger;
            var window = Application.Current.MainWindow as DinoDiner.PointOfSale.MainWindow;
            window.ShowScreen(screen);
            Order order = (Order)window.DataContext;
            order.Add(burger);
        }
        /// <summary>
        /// Handles a click on Deinonychus Double Button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The event args</param>
        void OnDeinonychusDoubleButtonClick(object sender, RoutedEventArgs e)
        {
            var burger = new DeinonychusDouble();
            var screen = new DeinonychusDoubleBurgerCustomizationControl();
            screen.DataContext = burger;
            var window = Application.Current.MainWindow as DinoDiner.PointOfSale.MainWindow;
            window.ShowScreen(screen);
            Order order = (Order)window.DataContext;
            order.Add(burger);
        }
        /// <summary>
        /// Handles a click on TRexTriple Button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The event args</param>
        void OnTRexTripleburgerButtonClick(object sender, RoutedEventArgs e)
        {
            var burger = new TRexTriple();
            var screen = new TRexTripleBurgerCustomizationControl();
            screen.DataContext = burger;
            var window = Application.Current.MainWindow as DinoDiner.PointOfSale.MainWindow;
            window.ShowScreen(screen);
            Order order = (Order)window.DataContext;
            order.Add(burger);
        }
        /// <summary>
        /// Handles a click on Carnotaurus Cheeseburger Button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The event args</param>
        void OnBrontowurstButtonClick(object sender, RoutedEventArgs e)
        {
            var burger = new Brontowurst();
            var screen = new BrontowurstCustomizationControl();
            screen.DataContext = burger;
            var window = Application.Current.MainWindow as DinoDiner.PointOfSale.MainWindow;
            window.ShowScreen(screen);
            Order order = (Order)window.DataContext;
            order.Add(burger);
        }
        /// <summary>
        /// Handles a click on Carnotaurus Cheeseburger Button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The event args</param>
        void OnPrehistoricPBJButtonClick(object sender, RoutedEventArgs e)
        {
            var burger = new PrehistoricPBJ();
            var screen = new PrehistoricPBJCustomizationControl();
            screen.DataContext = burger;
            var window = Application.Current.MainWindow as DinoDiner.PointOfSale.MainWindow;
            window.ShowScreen(screen);
            Order order = (Order)window.DataContext;
            order.Add(burger);
        }
        /// <summary>
        /// Handles a click on Pterodactyl Wings Button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The event args</param>
        void OnPterodactylWingsButtonClick(object sender, RoutedEventArgs e)
        {
            var burger = new PterodactylWings();
            var screen = new WingSauceCustomizationControl();
            screen.DataContext = burger;
            var window = Application.Current.MainWindow as DinoDiner.PointOfSale.MainWindow;
            window.ShowScreen(screen);
            Order order = (Order)window.DataContext;
            order.Add(burger);
        }
        /// <summary>
        /// Handles a click on Veloci-Wraptor Button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The event args</param>
        void OnVelociWraptorButtonClick(object sender, RoutedEventArgs e)
        {
            var burger = new VelociWraptor();
            var screen = new VelociWraptorCustomizationControl();
            screen.DataContext = burger;
            var window = Application.Current.MainWindow as DinoDiner.PointOfSale.MainWindow;
            window.ShowScreen(screen);
            Order order = (Order)window.DataContext;
            order.Add(burger); ;
        }
        /// <summary>
        /// Handles a click on Fryceritops Button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The event args</param>
        void OnFryceritopsButtonClick(object sender, RoutedEventArgs e)
        {
            var burger = new Fryceritops();
            var screen = new FryceritopsCustomizationControl();
            screen.DataContext = burger;
            var window = Application.Current.MainWindow as DinoDiner.PointOfSale.MainWindow;
            window.ShowScreen(screen);
            Order order = (Order)window.DataContext;
            order.Add(burger);

        }
        /// <summary>
        /// Handles a click on Meteor Mac And Cheese Button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The event args</param>
        void OnMeteorMacAndCheeseButtonClick(object sender, RoutedEventArgs e)
        {
            var burger = new MeteorMacAndCheese();
            var screen = new MeteorMacAndCheeseCustomizationControl();
            screen.DataContext = burger;
            var window = Application.Current.MainWindow as DinoDiner.PointOfSale.MainWindow;
            window.ShowScreen(screen);
            Order order = (Order)window.DataContext;
            order.Add(burger);
        }
        /// <summary>
        /// Handles a click on Carnotaurus Cheeseburger Button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The event args</param>
        void OnMezzorellaSticksButtonClick(object sender, RoutedEventArgs e)
        {
            var burger = new MezzoreallaSticks();
            var screen = new MezzorellaSticksCustomizationControl();
            screen.DataContext = burger;
            var window = Application.Current.MainWindow as DinoDiner.PointOfSale.MainWindow;
            window.ShowScreen(screen);
            Order order = (Order)window.DataContext;
            order.Add(burger);
        }
        /// <summary>
        /// Handles a click on Carnotaurus Cheeseburger Button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The event args</param>
        void OnTriceritotsButtonClick(object sender, RoutedEventArgs e)
        {
            var burger = new Triceritots();
            var screen = new TriceritotsCustomizationControl();
            screen.DataContext = burger;
            var window = Application.Current.MainWindow as DinoDiner.PointOfSale.MainWindow;
            window.ShowScreen(screen);
            Order order = (Order)window.DataContext;
            order.Add(burger);
        }
        /// <summary>
        /// Handles a click on Carnotaurus Cheeseburger Button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The event args</param>
        void OnPlilosodaButtonClick(object sender, RoutedEventArgs e)
        {
            var burger = new Plilosoda();
            var screen = new SodaFlavorCustomizationControl();
            screen.DataContext = burger;
            var window = Application.Current.MainWindow as DinoDiner.PointOfSale.MainWindow;
            window.ShowScreen(screen);
            Order order = (Order)window.DataContext;
            order.Add(burger);
        }
        /// <summary>
        /// Handles a click on Cretaceous Coffee Button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The event args</param>
        void OnCretaceousCoffeeButtonClick(object sender, RoutedEventArgs e)
        {
            var coffee = new CrustaceousCoffee();
            var screen = new CoffeeCreamCustomizationControl();
            screen.DataContext = coffee;
            var window = Application.Current.MainWindow as DinoDiner.PointOfSale.MainWindow;
            window.ShowScreen(screen);
            Order order = (Order)window.DataContext;
            order.Add(coffee);
        }
        /// <summary>
        /// Handles a click on DinoNuggets Button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The event args</param>
        void OnDinoNuggetsButtonClick(object sender, RoutedEventArgs e)
        {
            var nug = new DinoNuggets();
            var window = Application.Current.MainWindow as DinoDiner.PointOfSale.MainWindow;
            Order order = (Order)window.DataContext;
            order.Add(nug);
        }
    }
}
