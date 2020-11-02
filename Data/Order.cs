/*Order.cs
 * Steven Avila
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// A class to represent a customer's order
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Stores the items to the that has been chose by the customer.
        /// </summary>
        public Collection<MenuItem> items { get; set; } = new Collection<MenuItem>();

        /// <summary>
        /// A PropertyChangedEventHandler for NotifyPropertyChanged
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Stores the items to the that has been chose by the customer.
        /// </summary>
        public Collection<MenuItem> MenuItems { get; set; } = new Collection<MenuItem>();

        /// <summary>
        /// Calculates the subtotal for the customer's order by adding all the price from all items
        /// </summary>
        public double Subtotal
        {
            get
            {
                double sub = 0;
                foreach(IOrderItem item in MenuItems){
                    sub += item.Price;
                }

                return sub;
            }
        }

        /// <summary>
        /// Gets and sets the tax rate for the BleakwindBuffet in the State of Kansas (Is this even a buffet?).
        /// </summary>
        public double SalesTaxRate { get; set; } = 0.12;

        /// <summary>
        /// Calulates the tax of the items
        /// </summary>
        public double SalesTaxAmount => Subtotal * SalesTaxRate;

        /// <summary>
        /// The total of subtotal and tax for the order.
        /// </summary>
        public double TotalCost => Subtotal + SalesTaxAmount;

        /// <summary>
        /// Notifies that a property based on the name is changed.
        /// </summary>
        /// <param name="name">Name of property changed.</param>
        public void NotifyOfPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        /// <summary>
        /// 
        /// </summary>
        private void MenuItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            NotifyOfPropertyChanged("TotalCost");
            NotifyOfPropertyChanged("Subtotal");
            NotifyOfPropertyChanged("SalesTaxAmount");
        }

        private void ItemsChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if(e.NewItems != null)
            {
                foreach (MenuItem i in e.NewItems)
                {
                    i.PropertyChanged += MenuItemPropertyChanged;
                }
            }
            if (e.OldItems != null)
            {
                foreach (MenuItem i in e.OldItems)
                {
                    i.PropertyChanged -= MenuItemPropertyChanged;
                }
            }

            NotifyOfPropertyChanged("TotalCost");
            NotifyOfPropertyChanged("Subtotal");
            NotifyOfPropertyChanged("SalesTaxAmount");
            NotifyOfPropertyChanged("MenuItems");
        }

        public Order()
        {
            
        }




    }
}
