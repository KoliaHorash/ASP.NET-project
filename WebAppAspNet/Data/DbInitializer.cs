using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAspNet.Models;

namespace WebAppAspNet.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppointmentContext context)
        {
            context.Database.EnsureCreated();

            if (context.Appointment.Any())
            {
                return;
            }

            var appointments = new Appointment[]
            {
                new Appointment{DateCteate = DateTime.Parse("2018-09-01"), DateEndOfActuality = DateTime.Parse("2020-09-01"),CategoryId = 0, Description = "Description"},
                new Appointment{DateCteate = DateTime.Parse("2018-02-01"), DateEndOfActuality = DateTime.Parse("2021-09-01"),CategoryId = 0, Description = "Description1"}
            };
            foreach (Appointment ap in appointments)
            {
                context.Appointment.Add(ap);
            }
            context.SaveChanges();

            if (context.Category.Any())
            {
                return;
            }
            var categories = new Category[]
            {
                new Category{ Name = "Name1", Description = "Description1"},
                new Category{ Name = "name2", Description = "Description2"},
                new Category{ Name = "name3", Description = "Description3"}
            };
            foreach (Category c in categories)
            {
                context.Category.Add(c);
            }
            context.SaveChanges();
        }
    }
}
