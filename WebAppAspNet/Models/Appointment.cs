using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAspNet.Models
{
    public class Appointment
    {
        private DateTime dateCreate;
        private DateTime dateEndOfActuality;

        public int ID { get; set; }
        public DateTime DateCteate {
            get {return dateCreate.Date; }
            set {dateCreate = value.Date; }
        }
        public DateTime DateEndOfActuality {
            get {return dateEndOfActuality.Date; }
            set {dateEndOfActuality = value.Date; }
        }
        public int CategoryId { get; set; }
        public string Description { get; set; }

        public Category Category { get; set; }
    }
}
