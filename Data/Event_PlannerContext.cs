using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Event_Planner.Models;

namespace Event_Planner.Data
{
    public class Event_PlannerContext : DbContext
    {
        public Event_PlannerContext (DbContextOptions<Event_PlannerContext> options)
            : base(options)
        {
        }

        public DbSet<Event_Planner.Models.Locatie> Locatie { get; set; } = default!;
    }
}
