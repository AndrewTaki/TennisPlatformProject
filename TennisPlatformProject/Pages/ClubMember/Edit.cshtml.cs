using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TennisPlatformProject.Data;
using TennisPlatformProject.Models;

namespace TennisPlatformProject.Pages.ClubMember
{
    public class EditModel : PageModel
    {
        private readonly TennisPlatformProject.Data.TennisPlatformProjectContext _context;

        public EditModel(TennisPlatformProject.Data.TennisPlatformProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ClubMembers ClubMembers { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ClubMembers == null)
            {
                return NotFound();
            }

            var clubmembers =  await _context.ClubMembers.FirstOrDefaultAsync(m => m.Id == id);
            if (clubmembers == null)
            {
                return NotFound();
            }
            ClubMembers = clubmembers;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ClubMembers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClubMembersExists(ClubMembers.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ClubMembersExists(int id)
        {
          return (_context.ClubMembers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
