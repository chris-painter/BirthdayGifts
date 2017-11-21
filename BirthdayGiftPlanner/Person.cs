using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChrisPainter_BirthdayGiftPlanner
{
    public class Person: IDisplayable
    {
        public string Name { get; set; }
        public string Relationship { get; set; }
        public DateTime Birthday { get; set; }
        public double Budget { get; set; }
        public List<Gift> Gifts { get; set; }

        public Person()
        {

        }

        public string Display()
        {
            
            StringBuilder gifts = new StringBuilder();
            for(int i = 0; i < this.Gifts.Count; i++)
            {
                gifts.AppendLine(this.Gifts[i].Display());
               
            }
            string a = "Person: " + this.Name + "\r\n"
                + "Relationship: " + this.Relationship + "\r\n"
                + "Birthday: " + this.Birthday.ToString("M/dd/yyyy") + "\r\n"
                + "Budget: " + this.Budget.ToString("c") + "\r\n"
                + "Gifts: " + "\r\n" + "----------------------------------------------" + "\r\n"
                + gifts.ToString() + "\r\n" + "----------------------------------------------" + "\r\n";

            return a;
        }
    }
}
