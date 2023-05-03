/*
* Author: Jyad Aljohani
* File name: CashViewModel.cs
* Purpose: CashViewModel class
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Enums;
using DinoDiner.Data;
using RoundRegister;
using System.ComponentModel;

namespace DinoDiner.PointOfSale
{
    /// <summary>
    /// An intermediate class to handle the CashControl.
    /// </summary>
    public class CashViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Notifies when a property of this class changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Represents the order.
        /// </summary>
        private Order _order;

        /// <summary>
        /// Constructs a new CashViewModel
        /// </summary>
        /// <param name="order">The order to process</param>
        public CashViewModel(Order order)
        {
            _order = order;
            _incomingTotal = (decimal)order.Total;
            _amountDue = 0;
            _changeOwed = 0;
            _change = 0;
            _incomingPennies = 0;
            _incomingNickels = 0;
            _incomingDimes = 0;
            _incomingQuarters = 0;
            _incomingDollars = 0;
            _incomingHalfDollars = 0;
            _incomingOnes = 0;
            _incomingTwos = 0;
            _incomingFives = 0;
            _incomingTens = 0;
            _incomingTwenties = 0;
            _incomingFifties = 0;
            _incomingHundreds = 0;
        }

        /// <summary>
        /// The amount of Pennies in the drawer.
        /// </summary>
        public uint DrawerPennies
        {
            get => CashDrawer.Nickles;
            set
            {
                CashDrawer.Nickles = value;
                OnPropertyChanged(nameof(this.DrawerPennies));
            }
        }

        /// <summary>
        /// The amount of Pennies that the customer paid.
        /// </summary>
        public uint _incomingPennies;

        /// <summary>
        ///  The amount of Pennies that the customer paid.
        /// </summary>
        public uint IncomingPennies
        {
            get => _incomingPennies;
            set
            {
                if (_incomingPennies != value)
                {
                    _incomingPennies = value;
                    OnPropertyChanged(nameof(this.IncomingPennies));
                    MakeChange();
                }
            }
        }

        /// <summary>
        /// The amount of Pennies that the customer will receive.
        /// </summary>
        public uint _outgoingPennies;

        /// <summary>
        /// The amount of Pennies that the customer will receive.
        /// </summary>
        public uint OutgoingPennies
        {
            get => _outgoingPennies;
            private set
            {
                if (value <= CashDrawer.Pennies)
                {
                    _outgoingPennies = value;
                    OnPropertyChanged(nameof(this.OutgoingPennies));
                }
            }
        }

        /// <summary>
        /// The amount of Nickels in the drawer.
        /// </summary>
        public uint DrawerNickels
        {
            get => CashDrawer.Nickles;
            set
            {
                CashDrawer.Nickles = value;
                OnPropertyChanged(nameof(this.DrawerNickels));
            }
        }

        /// <summary>
        /// The amount of Nickels that the customer paid.
        /// </summary>
        public uint _incomingNickels;

        /// <summary>
        /// The amount of Nickels that the customer paid.
        /// </summary>
        public uint IncomingNickels
        {
            get => _incomingNickels;
            set
            {
                if (_incomingNickels != value)
                {
                    _incomingNickels = value;
                    OnPropertyChanged(nameof(this.IncomingNickels));
                    MakeChange();
                }
            }
        }

        /// <summary>
        /// The amount of Nickels that the customer will receive.
        /// </summary>
        public uint _outgoingNickels;

        /// <summary>
        /// The amount of Nickels that the customer will receive.
        /// </summary>
        public uint OutgoingNickels
        {
            get => _outgoingNickels;
            private set
            {
                if (value <= CashDrawer.Nickles)
                {
                    _outgoingNickels = value;
                    OnPropertyChanged(nameof(this.OutgoingNickels));
                }
            }
        }

        /// <summary>
        /// The amount of Dimes in the drawer.
        /// </summary>
        public uint DrawerDimes
        {
            get => CashDrawer.Dimes;
            set
            {
                CashDrawer.Dimes = value;
                OnPropertyChanged(nameof(this.DrawerDimes));
            }
        }

        /// <summary>
        /// The amount of Dimes that the customer paid.
        /// </summary>
        public uint _incomingDimes;

        /// <summary>
        /// The amount of Dimes that the customer paid.
        /// </summary>
        public uint IncomingDimes
        {
            get => _incomingDimes;
            set
            {
                if (_incomingDimes != value)
                {
                    _incomingDimes = value;
                    OnPropertyChanged(nameof(this.IncomingDimes));
                    MakeChange();
                }
            }
        }

        /// <summary>
        /// The amount of Dimes that the customer will receive.
        /// </summary>
        public uint _outgoingDimes;

        /// <summary>
        /// The amount of Dimes that the customer will receive.
        /// </summary>
        public uint OutgoingDimes
        {
            get => _outgoingDimes;
            private set
            {
                if (value <= CashDrawer.Dimes)
                {
                    _outgoingDimes = value;
                    OnPropertyChanged(nameof(this.OutgoingDimes));
                }
            }
        }

        /// <summary>
        /// The amount of Quarters in the drawer.
        /// </summary>
        public uint DrawerQuarters
        {
            get => CashDrawer.Quarters;
            set
            {
                CashDrawer.Quarters = value;
                OnPropertyChanged(nameof(this.DrawerQuarters));
            }
        }

        /// <summary>
        /// The amount of Quarters that the customer paid.
        /// </summary>
        public uint _incomingQuarters;

        /// <summary>
        /// The amount of Quarters that the customer paid.
        /// </summary>
        public uint IncomingQuarters
        {
            get => _incomingQuarters;
            set
            {
                if (_incomingQuarters != value)
                {
                    _incomingQuarters = value;
                    OnPropertyChanged(nameof(this.IncomingQuarters));
                    MakeChange();
                }
            }
        }

        /// <summary>
        /// The amount of Quarters that the customer will receive.
        /// </summary>
        public uint _outgoingQuarters;

        /// <summary>
        /// The amount of Quarters that the customer will receive.
        /// </summary>
        public uint OutgoingQuarters
        {
            get => _outgoingQuarters;
            private set
            {
                if (value <= CashDrawer.Quarters)
                {
                    _outgoingQuarters = value;
                    OnPropertyChanged(nameof(this.OutgoingQuarters));
                }
            }
        }

        /// <summary>
        /// The amount of Dollars in the drawer.
        /// </summary>
        public uint DrawerDollars
        {
            get => CashDrawer.DollarCoins;
            set
            {
                CashDrawer.DollarCoins = value;
                OnPropertyChanged(nameof(this.DrawerDollars));
            }
        }

        /// <summary>
        /// The amount of Dollars that the customer paid.
        /// </summary>
        public uint _incomingDollars;

        /// <summary>
        /// The amount of Dollars that the customer paid.
        /// </summary>
        public uint IncomingDollars
        {
            get => _incomingDollars;
            set
            {
                if (_incomingDollars != value)
                {
                    _incomingDollars = value;
                    OnPropertyChanged(nameof(this.IncomingDollars));
                    MakeChange();
                }
            }
        }

        /// <summary>
        /// The amount of Dollars that the customer will receive.
        /// </summary>
        public uint _outgoingDollars;

        /// <summary>
        /// The amount of Dollars that the customer will receive.
        /// </summary>
        public uint OutgoingDollars
        {
            get => _outgoingDollars;
            private set
            {
                if (value <= CashDrawer.DollarCoins)
                {
                    _outgoingDollars = value;
                    OnPropertyChanged(nameof(this.OutgoingDollars));
                }
            }
        }

        /// <summary>
        /// The amount of Half Dollars in the drawer.
        /// </summary>
        public uint DrawerHalfDollars
        {
            get => CashDrawer.HalfDollarCoins;
            set
            {
                CashDrawer.HalfDollarCoins = value;
                OnPropertyChanged(nameof(this.DrawerHalfDollars));
            }
        }

        /// <summary>
        /// The amount of Half Dollars that the customer paid.
        /// </summary>
        public uint _incomingHalfDollars;

        /// <summary>
        /// The amount of Half Dollars that the customer paid.
        /// </summary>
        public uint IncomingHalfDollars
        {
            get => _incomingHalfDollars;
            set
            {
                if (_incomingHalfDollars != value)
                {
                    _incomingHalfDollars = value;
                    OnPropertyChanged(nameof(this.IncomingHalfDollars));
                    MakeChange();
                }
            }
        }

        /// <summary>
        /// The amount of Half Dollars that the customer will receive.
        /// </summary>
        public uint _outgoingHalfDollars;

        /// <summary>
        /// The amount of Half Dollars that the customer will receive.
        /// </summary>
        public uint OutgoingHalfDollars
        {
            get => _outgoingHalfDollars;
            private set
            {
                if (value <= CashDrawer.HalfDollarCoins)
                {
                    _outgoingHalfDollars = value;
                    OnPropertyChanged(nameof(this.OutgoingHalfDollars));
                }
            }
        }

        /// <summary>
        /// The amount of Ones in the drawer.
        /// </summary>
        public uint DrawerOnes
        {
            get => CashDrawer.Ones;
            set
            {
                CashDrawer.Ones = value;
                OnPropertyChanged(nameof(this.DrawerOnes));
            }
        }

        /// <summary>
        /// The amount of Ones that the customer paid.
        /// </summary>
        public uint _incomingOnes;

        /// <summary>
        /// The amount of Ones that the customer paid.
        /// </summary>
        public uint IncomingOnes
        {
            get => _incomingOnes;
            set
            {
                if (_incomingOnes != value)
                {
                    _incomingOnes = value;
                    OnPropertyChanged(nameof(this.IncomingOnes));
                    MakeChange();
                }
            }
        }

        /// <summary>
        /// The amount of Ones that the customer will receive.
        /// </summary>
        public uint _outgoingOnes;

        /// <summary>
        /// The amount of Ones that the customer will receive.
        /// </summary>
        public uint OutgoingOnes
        {
            get => _outgoingOnes;
            private set
            {
                if (value <= CashDrawer.Ones)
                {
                    _outgoingOnes = value;
                    OnPropertyChanged(nameof(this.OutgoingOnes));
                }
            }
        }

        /// <summary>
        /// The amount of Twos in the drawer.
        /// </summary>
        public uint DrawerTwos
        {
            get => CashDrawer.Twos;
            set
            {
                CashDrawer.Twos = value;
                OnPropertyChanged(nameof(this.DrawerTwos));
            }
        }

        /// <summary>
        /// The amount of Twos that the customer paid.
        /// </summary>
        public uint _incomingTwos;

        /// <summary>
        /// The amount of Twos that the customer paid.
        /// </summary>
        public uint IncomingTwos
        {
            get => _incomingTwos;
            set
            {
                if (_incomingTwos != value)
                {
                    _incomingTwos = value;
                    OnPropertyChanged(nameof(this.IncomingTwos));
                    MakeChange();
                }
            }
        }

        /// <summary>
        /// The amount of Twos that the customer will receive.
        /// </summary>
        public uint _outgoingTwos;

        /// <summary>
        /// The amount of Twos that the customer will receive.
        /// </summary>
        public uint OutgoingTwos
        {
            get => _outgoingTwos;
            private set
            {
                if (value <= CashDrawer.Twos)
                {
                    _outgoingTwos = value;
                    OnPropertyChanged(nameof(this.OutgoingTwos));
                }
            }
        }

        /// <summary>
        /// The amount of Fives in the drawer.
        /// </summary>
        public uint DrawerFives
        {
            get => CashDrawer.Fives;
            set
            {
                CashDrawer.Fives = value;
                OnPropertyChanged(nameof(this.DrawerFives));
            }
        }

        /// <summary>
        /// The amount of Fives that the customer paid.
        /// </summary>
        public uint _incomingFives;

        /// <summary>
        /// The amount of Fives that the customer paid.
        /// </summary>
        public uint IncomingFives
        {
            get => _incomingFives;
            set
            {
                if (_incomingFives != value)
                {
                    _incomingFives = value;
                    OnPropertyChanged(nameof(this.IncomingFives));
                    MakeChange();
                }
            }
        }

        /// <summary>
        /// The amount of Fives that the customer will receive.
        /// </summary>
        public uint _outgoingFives;

        /// <summary>
        /// The amount of Fives that the customer will receive.
        /// </summary>
        public uint OutgoingFives
        {
            get => _outgoingFives;
            private set
            {
                if (value <= CashDrawer.Fives)
                {
                    _outgoingFives = value;
                    OnPropertyChanged(nameof(this.OutgoingFives));
                }
            }
        }

        /// <summary>
        /// The amount of Tens in the drawer.
        /// </summary>
        public uint DrawerTens
        {
            get => CashDrawer.Tens;
            set
            {
                CashDrawer.Tens = value;
                OnPropertyChanged(nameof(this.DrawerTens));
            }
        }

        /// <summary>
        /// The amount of Tens that the customer paid.
        /// </summary>
        public uint _incomingTens;

        /// <summary>
        /// The amount of Tens that the customer paid.
        /// </summary>
        public uint IncomingTens
        {
            get => _incomingTens;
            set
            {
                if (_incomingTens != value)
                {
                    _incomingTens = value;
                    OnPropertyChanged(nameof(this.IncomingTens));
                    MakeChange();
                }
            }
        }

        /// <summary>
        /// The amount of Tens that the customer will receive.
        /// </summary>
        public uint _outgoingTens;

        /// <summary>
        /// The amount of Tens that the customer will receive.
        /// </summary>
        public uint OutgoingTens
        {
            get => _outgoingTens;
            private set
            {
                if (value <= CashDrawer.Tens)
                {
                    _outgoingTens = value;
                    OnPropertyChanged(nameof(this.OutgoingTens));
                }
            }
        }

        /// <summary>
        /// The amount of Twenties in the drawer.
        /// </summary>
        public uint DrawerTwenties
        {
            get => CashDrawer.Twenties;
            set
            {
                CashDrawer.Twenties = value;
                OnPropertyChanged(nameof(this.DrawerTwenties));
            }
        }

        /// <summary>
        /// The amount of Twenties that the customer paid.
        /// </summary>
        public uint _incomingTwenties;

        /// <summary>
        /// The amount of Twenties that the customer paid.
        /// </summary>
        public uint IncomingTwenties
        {
            get => _incomingTwenties;
            set
            {
                if (_incomingTwenties != value)
                {
                    _incomingTwenties = value;
                    OnPropertyChanged(nameof(this.IncomingTwenties));
                    MakeChange();
                }
            }
        }

        /// <summary>
        /// The amount of Twenties that the customer will receive.
        /// </summary>
        public uint _outgoingTwenties;

        /// <summary>
        /// The amount of Twenties that the customer will receive.
        /// </summary>
        public uint OutgoingTwenties
        {
            get => _outgoingTwenties;
            private set
            {
                if (value <= CashDrawer.Twenties)
                {
                    _outgoingTwenties = value;
                    OnPropertyChanged(nameof(this.OutgoingTwenties));
                }
            }
        }

        /// <summary>
        /// The amount of Fifties in the drawer.
        /// </summary>
        public uint DrawerFifties
        {
            get => CashDrawer.Fifties;
            set
            {
                CashDrawer.Fifties = value;
                OnPropertyChanged(nameof(this.DrawerFifties));
            }
        }

        /// <summary>
        /// The amount of Fifties that the customer paid.
        /// </summary>
        public uint _incomingFifties;

        /// <summary>
        /// The amount of Fifties that the customer paid.
        /// </summary>
        public uint IncomingFifties
        {
            get => _incomingFifties;
            set
            {
                if (_incomingFifties != value)
                {
                    _incomingFifties = value;
                    OnPropertyChanged(nameof(this.IncomingFifties));
                    MakeChange();
                }
            }
        }

        /// <summary>
        /// The amount of Fifties that the customer will receive.
        /// </summary>
        public uint _outgoingFifties;

        /// <summary>
        /// The amount of Fifties that the customer will receive.
        /// </summary>
        public uint OutgoingFifties
        {
            get => _outgoingFifties;
            private set
            {
                if (value <= CashDrawer.Fifties)
                {
                    _outgoingFifties = value;
                    OnPropertyChanged(nameof(this.OutgoingFifties));
                }
            }
        }

        /// <summary>
        /// The amount of Hundreds in the drawer.
        /// </summary>
        public uint DrawerHundreds
        {
            get => CashDrawer.Hundreds;
            set
            {
                CashDrawer.Hundreds = value;
                OnPropertyChanged(nameof(this.DrawerHundreds));
            }
        }

        /// <summary>
        /// The amount of Hundreds that the customer paid.
        /// </summary>
        public uint _incomingHundreds;

        /// <summary>
        /// The amount of Hundreds that the customer paid.
        /// </summary>
        public uint IncomingHundreds
        {
            get => _incomingHundreds;
            set
            {
                if (_incomingHundreds != value)
                {
                    _incomingHundreds = value;
                    OnPropertyChanged(nameof(this.IncomingHundreds));
                    MakeChange();

                }
            }
        }

        /// <summary>
        /// The amount of Hundreds that the customer will receive.
        /// </summary>
        public uint _outgoingHundreds;

        /// <summary>
        /// The amount of Hundreds that the customer will receive.
        /// </summary>
        public uint OutgoingHundreds
        {
            get => _outgoingHundreds;
            private set
            {
                if (value <= CashDrawer.Hundreds)
                {
                    _outgoingHundreds = value;
                    OnPropertyChanged(nameof(this.OutgoingHundreds));
                }
            }
        }

        /// <summary>
        /// The Total amount in the drawer.
        /// </summary>
        public decimal DrawerTotal
        {
            get => CashDrawer.GetTotal();
        }

        /// <summary>
        /// The total amount that the customer paid.
        /// </summary>
        public decimal _incomingTotal;

        /// <summary>
        /// The total amount that the customer paid.
        /// </summary>
        public decimal IncomingTotal
        {
            get => _incomingTotal;
            set
            {
                if (_incomingTotal != value)
                {
                    _incomingTotal = value;
                    OnPropertyChanged(nameof(this.IncomingTotal));
                }
            }
        }

        /// <summary>
        /// The amount of change owed to the custoumer.
        /// </summary>
        public decimal _changeOwed;

        /// <summary>
        /// The amount of change owed to the custoumer.
        /// </summary>
        public decimal ChangeOwed
        {
            get => _changeOwed;
            set
            {
                if (_changeOwed != value)
                {
                    _changeOwed = value;
                    OnPropertyChanged(nameof(this.ChangeOwed));
                }
            }
        }

        /// <summary>
        /// The change that the customer should receive.
        /// </summary>
        public decimal _change;

        /// <summary>
        /// The change that the customer should receive.
        /// </summary>
        public decimal Change
        {
            get => _change;
            set
            {
                if (_change != value)
                {
                    _change = value;
                    OnPropertyChanged(nameof(this.Change));
                }
            }
        }

        /// <summary>
        /// The amount due that should be paid by the customer.
        /// </summary>
        public decimal _amountDue;

        /// <summary>
        /// The amount due that should be paid by the customer.
        /// </summary>
        public decimal AmountDue
        {
            get => _amountDue;
            set
            {
                if (_amountDue != value)
                {
                    _amountDue = value;
                    OnPropertyChanged(nameof(this.AmountDue));
                }
            }
        }

        /// <summary>
        /// Finalizes the transaction when paid in cash.
        /// </summary>
        public void FinalizingTransaction()
        {
            CashDrawer.Open();
            MakeChange();
            PrintReceipt(_order);
            DrawerHundreds -= OutgoingHundreds;
            DrawerHundreds += IncomingHundreds;
            DrawerFifties -= OutgoingFifties;
            DrawerFifties += IncomingFifties;
            DrawerTwenties -= OutgoingTwenties;
            DrawerTwenties += IncomingTwenties;
            DrawerTens -= OutgoingTens;
            DrawerTens += IncomingTens;
            DrawerFives -= OutgoingFives;
            DrawerFives += IncomingFives;
            DrawerTwos -= OutgoingTwos;
            DrawerTwos += IncomingTwos;
            DrawerOnes -= OutgoingOnes;
            DrawerOnes += IncomingOnes;
            DrawerDollars -= OutgoingDollars;
            DrawerDollars += IncomingDollars;
            DrawerHalfDollars -= OutgoingHalfDollars;
            DrawerHalfDollars += IncomingHalfDollars;
            DrawerQuarters -= OutgoingQuarters;
            DrawerQuarters += IncomingQuarters;
            DrawerDimes -= OutgoingDimes;
            DrawerDimes += IncomingDimes;
            DrawerNickels -= OutgoingNickels;
            DrawerNickels += IncomingNickels;
            DrawerPennies -= OutgoingPennies;
            DrawerPennies += IncomingPennies;
        }

        /// <summary>
        /// Calculates the change that the customer should receive.
        /// </summary>
        private void MakeChange()
        {
            int total = (int)(IncomingTotal * 100);
            int paid = (int)((IncomingPennies * 0.01 + IncomingNickels * 0.05 + IncomingDimes * 0.1 + IncomingQuarters * 0.25 + IncomingDollars * 1.0 + IncomingHalfDollars * 0.5 + IncomingOnes * 1.0 + IncomingTwos * 2.0 + IncomingFives * 5.0 + IncomingTens * 10.0 + IncomingTwenties * 20.0 + IncomingFifties * 50.0 + IncomingHundreds * 100.0) * 100);
            AmountDue = (_order.Total - ((decimal)paid / 100));
            ChangeOwed = paid - _order.Total * 100;
            if (ChangeOwed <= 0)
            {
                OutgoingHundreds = 0;
                OutgoingFifties = 0;
                OutgoingTwenties = 0;
                OutgoingTens = 0;
                OutgoingFives = 0;
                OutgoingTwos = 0;
                OutgoingOnes = 0;
                OutgoingDollars = 0;
                OutgoingQuarters = 0;
                OutgoingDimes = 0;
                OutgoingNickels = 0;
                OutgoingPennies = 0;
                return;
            }
            uint changeInCents = (uint)ChangeOwed;
            uint count = changeInCents / 10000;
            if (count > DrawerHundreds) count = DrawerHundreds;
            changeInCents -= count * 10000;
            OutgoingHundreds = count;
            count = changeInCents / 5000;
            if (count > DrawerFifties) count = DrawerFifties;
            changeInCents -= count * 5000;
            OutgoingFifties = count;
            count = changeInCents / 2000;
            if (count > DrawerTwenties) count = DrawerTwenties;
            changeInCents -= count * 2000;
            OutgoingTwenties = count;
            count = changeInCents / 1000;
            if (count > DrawerTens) count = DrawerTens;
            changeInCents -= count * 1000;
            OutgoingTens = count;
            count = changeInCents / 500;
            if (count > DrawerFives) count = DrawerFives;
            changeInCents -= count * 500;
            OutgoingFives = count;
            count = changeInCents / 200;
            if (count > DrawerTwos) count = DrawerTwos;
            changeInCents -= count * 200;
            OutgoingTwos = count;
            count = changeInCents / 100;
            if (count > DrawerOnes) count = DrawerOnes;
            changeInCents -= count * 100;
            OutgoingOnes = count;
            count = changeInCents / 100;
            if (count > DrawerDollars) count = DrawerDollars;
            changeInCents -= count * 100;
            OutgoingDollars = count;
            count = changeInCents / 50;
            if (count > DrawerHalfDollars) count = DrawerHalfDollars;
            changeInCents -= count * 50;
            OutgoingHalfDollars = count;
            count = changeInCents / 25;
            if (count > DrawerQuarters) count = DrawerQuarters;
            changeInCents -= count * 25;
            OutgoingQuarters = count;
            count = changeInCents / 10;
            if (count > DrawerDimes) count = DrawerDimes;
            changeInCents -= count * 10;
            OutgoingDimes = count;
            count = changeInCents / 5;
            if (count > DrawerNickels) count = DrawerNickels;
            changeInCents -= count * 5;
            OutgoingNickels = count;
            count = changeInCents / 1;
            if (count > DrawerPennies) count = DrawerPennies;
            changeInCents -= count * 1;
            OutgoingPennies = count;
            Change = -AmountDue;
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
            ReceiptPrinter.PrintLine("Payment method: Cash");
            ReceiptPrinter.PrintLine($"Change owed: ${Change.ToString()}");
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

        /// <summary>
        /// Used to trigger a PropertyChanged event.
        /// </summary>
        /// <param name="propertyName">The name of the property that is changing</param>
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
