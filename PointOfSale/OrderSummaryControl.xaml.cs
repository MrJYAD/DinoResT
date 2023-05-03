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
using DinoDiner.Data;
using DinoDiner.Data.Drinks;
using DinoDiner.Data.Entrees;
using DinoDiner.Data.Enums;
using DinoDiner.Data.Sides;
namespace DinoDiner.PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles the swapping the Customization screen
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The event args</param>
        void SwappingCustomization(object sender, RoutedEventArgs e)
        {
            var window = Application.Current.MainWindow as PointOfSale.MainWindow;
            if (e.OriginalSource is Button button)
            {
                if (button.DataContext is IMenuItem item)
                {
                    if (item is AllosaurusAllAmericanBurger)
                    {
                        var burger = new AllosaurusAllAmericanBurgerCustomizationControl();
                        burger.DataContext = item;
                        window.ShowScreen(burger);
                    }
                    else if (item is CarnotaurusCheeseburger)
                    {
                        var Cheesebruger = new CarnotaurusCheeseburgerCustomizationControl();
                        Cheesebruger.DataContext = item;
                        window.ShowScreen(Cheesebruger);
                    }
                    else if (item is DeinonychusDouble)
                    {
                        var Deino = new DeinonychusDoubleBurgerCustomizationControl();
                        Deino.DataContext = item;
                        window.ShowScreen(Deino);
                    }
                    else if (item is TRexTriple)
                    {
                        var Trexburger = new TRexTripleBurgerCustomizationControl();
                        Trexburger.DataContext = item;
                        window.ShowScreen(Trexburger);
                    }
                    else if (item is Brontowurst)
                    {
                        var bro = new BrontowurstCustomizationControl();
                        bro.DataContext = item;
                        window.ShowScreen(bro);
                    }
                    else if (item is PrehistoricPBJ)
                    {
                        var pbj = new PrehistoricPBJCustomizationControl();
                        pbj.DataContext = item;
                        window.ShowScreen(pbj);
                    }
                    else if (item is PterodactylWings)
                    {
                        var wings = new WingSauceCustomizationControl();
                        wings.DataContext = item;
                        window.ShowScreen(wings);
                    }
                    else if (item is VelociWraptor)
                    {
                        var wrap = new VelociWraptorCustomizationControl();
                        wrap.DataContext = item;
                        window.ShowScreen(wrap);
                    }
                    else if (item is Fryceritops)
                    {
                        var fry = new FryceritopsCustomizationControl();
                        fry.DataContext = item;
                        window.ShowScreen(fry);
                    }
                    else if (item is MeteorMacAndCheese)
                    {
                        var mnc = new MeteorMacAndCheeseCustomizationControl();
                        mnc.DataContext = item;
                        window.ShowScreen(mnc);
                    }
                    else if (item is MezzoreallaSticks)
                    {
                        var sticks = new MezzorellaSticksCustomizationControl();
                        sticks.DataContext = item;
                        window.ShowScreen(sticks);
                    }
                    else if (item is Plilosoda)
                    {
                        var soda = new SodaFlavorCustomizationControl();
                        soda.DataContext = item;
                        window.ShowScreen(soda);
                    }
                    else if (item is CrustaceousCoffee)
                    {
                        var coffee = new CoffeeCreamCustomizationControl();
                        coffee.DataContext = item;
                        window.ShowScreen(coffee);
                    }
                    else if (item is Triceritots)
                    {
                        var coffee = new TriceritotsCustomizationControl();
                        coffee.DataContext = item;
                        window.ShowScreen(coffee);
                    }

                }
            }
        }

        /// <summary>
        /// Handles a click on Remove From Order button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The event args</param>
        void OnRemoveFromOrderClick(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is Button button)
            {
                if (button.DataContext is IMenuItem item)
                {
                    var window = Application.Current.MainWindow as PointOfSale.MainWindow;
                    Order order = (Order)window.DataContext;
                    order.Remove(item);
                }

            }
        }
    }
}
