using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TennisPlatformProject.Data;
using TennisPlatformProject.Models;

namespace TennisPlatformProject.Pages.ClubMember
{
    public class DetailsModel : PageModel
    {
        private readonly TennisPlatformProject.Data.TennisPlatformProjectContext _context;

        public DetailsModel(TennisPlatformProject.Data.TennisPlatformProjectContext context)
        {
            _context = context;
        }

      public ClubMembers ClubMembers { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ClubMembers == null)
            {
                return NotFound();
            }

            var clubmembers = await _context.ClubMembers.FirstOrDefaultAsync(m => m.Id == id);
            if (clubmembers == null)
            {
                return NotFound();
            }
            else 
            {
                ClubMembers = clubmembers;
            }
            return Page();
        }
    }
}
