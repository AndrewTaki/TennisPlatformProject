using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TennisPlatformProject.Data;
using TennisPlatformProject.Models;

namespace TennisPlatformProject.Pages.ClubBookings
{
    public class CreateModel : PageModel
    {
        private readonly TennisPlatformProject.Data.TennisPlatformProjectContext _context;

        public CreateModel(TennisPlatformProject.Data.TennisPlatformProjectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Bookings Bookings { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Bookings == null || Bookings == null)
            {
                return Page();
            }

            _context.Bookings.Add(Bookings);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
