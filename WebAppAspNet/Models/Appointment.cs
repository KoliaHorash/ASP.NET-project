using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAspNet.Models
{
    public class Appointment
    {
        private DateTime dateCreate;
        private DateTime dateEndOfActuality;

        public int ID { get; set; }
        public DateTime DateCteate
        {
            get {return Convert.ToDateTime(dateCreate.ToString("d.M.yyy", CultureInfo.InvariantCulture)); }
            set {dateCreate = Convert.ToDateTime(value.ToString("d.M.yyy", CultureInfo.InvariantCulture)); }
        }
        public DateTime DateEndOfActuality
        {
            get {return Convert.ToDateTime(dateEndOfActuality.ToString("d.M.yyy", CultureInfo.InvariantCulture)); }
            set { dateEndOfActuality = Convert.ToDateTime(value.ToString("d.M.yyy", CultureInfo.InvariantCulture)); }
        }
        public int CategoryId { get; set; }
        public string Description { get; set; }

        public Category Category { get; set; }
    }
}
