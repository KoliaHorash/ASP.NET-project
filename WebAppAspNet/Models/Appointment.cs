using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAspNet.Models
{
    public class Appointment
    {
        public int ID { get; set; }
        public DateTime DateCteate { get; set; }
        public DateTime DateEndOfActuality { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }

        public Category Category { get; set; }
    }
}
