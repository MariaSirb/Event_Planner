using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Event_Planner.Data;
using Event_Planner.Models;

namespace Event_Planner.Pages.Locatii
{
    public class IndexModel : PageModel
    {
        private readonly Event_Planner.Data.Event_PlannerContext _context;

        public IndexModel(Event_Planner.Data.Event_PlannerContext context)
        {
            _context = context;
        }

        public IList<Locatie> Locatie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Locatie != null)
            {
                Locatie = await _context.Locatie.ToListAsync();
            }
        }
    }
}
