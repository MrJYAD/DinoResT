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
{   /// <summary>
    /// Interaction logic for CurrencyControl.xaml
    /// </summary>
    public partial class CurrencyControl : UserControl
    {
        public CurrencyControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// A dependency property representing the quantity of money given by the customer.
        /// </summary>
        public static DependencyProperty CustomerQuantityProperty = DependencyProperty.Register("CustomerQuantity", typeof(int), typeof(CurrencyControl), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        /// <summary>
        /// The quantity of money given by the customer.
        /// </summary>
        public int CustomerQuantity
        {
            get => (int)GetValue(CustomerQuantityProperty);
            set => SetValue(CustomerQuantityProperty, value);
        }

        /// <summary>
        /// A dependency property representing the quantity of change given to the customer.
        /// </summary>
        public static DependencyProperty ChangeQuantityProperty = DependencyProperty.Register("ChangeQuantity", typeof(int), typeof(CurrencyControl), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));

        /// <summary>
        /// The quantity of change given to the customer.
        /// </summary>
        public int ChangeQuantity
        {
            get => (int)GetValue(ChangeQuantityProperty);
            set => SetValue(ChangeQuantityProperty, value);
        }

        /// <summary>
        /// A dependency property representing the denomination of change.
        /// </summary>
        public static DependencyProperty LabelProperty = DependencyProperty.Register("Label", typeof(string), typeof(CurrencyControl), new FrameworkPropertyMetadata("0", FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));

        /// <summary>
        /// The denomination of change.
        /// </summary>
        public string Label
        {
            get => (string)GetValue(LabelProperty);
            set => SetValue(LabelProperty, value);
        }

        /// <summary>
        /// Handles a click on the "+" button
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The event arguments</param>
        void OnPlusClick(object sender, RoutedEventArgs e)
        {
            CustomerQuantity++;
        }

        /// <summary>
        /// Handles a click on the "-" button
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The event arguments</param>
        void OnMinusClick(object sender, RoutedEventArgs e)
        {
            CustomerQuantity--;
        }
    }
}
