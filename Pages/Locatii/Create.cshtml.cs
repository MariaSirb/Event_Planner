using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Event_Planner.Data;
using Event_Planner.Models;
using System.IO;

namespace Event_Planner.Pages.Locatii
{
    public class CreateModel : PageModel
    {
        private readonly Event_Planner.Data.Event_PlannerContext _context;

        public CreateModel(Event_Planner.Data.Event_PlannerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Locatie Locatie { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                if(!string.IsNullOrEmpty(Locatie.Poza))
                {
                    string imagesFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");
                    string imagePath = Path.Combine(imagesFolder, Locatie.Poza);
                    if(!System.IO.File.Exists(imagePath))
                    {
                        ModelState.AddModelError("Locatie.Poza", "The specified image does not exist.");
                    }
                }
                return Page();
            }


            _context.Locatie.Add(Locatie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
