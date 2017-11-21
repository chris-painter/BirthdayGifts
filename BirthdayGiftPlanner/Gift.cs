using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChrisPainter_BirthdayGiftPlanner
{
    public class Gift: IDisplayable
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        private double totalPrice;
        
        public Gift()
        {

        }
        public double TotalPrice
        {
            get
            {
                totalPrice = this.Price * this.Quantity;
                return totalPrice;
            }

            set
            {
                totalPrice = value;
            }
        }

        public string Display()
        {
            string a = "Name: " + this.Name + "\r\n"
                + "Price: " + this.Price.ToString("c") + "\r\n"
                + "Qty: " + this.Quantity.ToString();
            return a;
        }
    }
}
