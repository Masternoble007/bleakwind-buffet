/*MenuItem.cs
 * Steven Avila
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    public abstract class MenuItem : IOrderItem, INotifyPropertyChanged, IMenuItem
    {

        /// <summary>
        /// PropertyChangedEventHandler for NotifyPropertyChanged.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// To add the special instructions to the order.
        /// </summary>
        private List<string> specialInstructions = new List<string>();

        /// <summary>
        /// The price of the item.
        /// </summary>
        public virtual double Price { get; set; }

        /// <summary>
        /// Calories of the item
        /// </summary>
        public virtual uint Calories { get; set; }

        /// <summary>
        /// The special instructions of the item
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        public virtual string[] SI => specialInstructions.ToArray();

        public virtual void NotifyOfPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }






    }
}
