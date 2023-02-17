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
    public class DetailsModel : PageModel
    {
        private readonly Event_Planner.Data.Event_PlannerContext _context;

        public DetailsModel(Event_Planner.Data.Event_PlannerContext context)
        {
            _context = context;
        }

      public Locatie Locatie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Locatie == null)
            {
                return NotFound();
            }

            var locatie = await _context.Locatie.FirstOrDefaultAsync(m => m.ID == id);
            if (locatie == null)
            {
                return NotFound();
            }
            else 
            {
                Locatie = locatie;
            }
            return Page();
        }
    }
}
