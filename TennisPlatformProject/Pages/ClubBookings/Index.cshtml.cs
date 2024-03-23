using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TennisPlatformProject.Data;
using TennisPlatformProject.Models;

namespace TennisPlatformProject.Pages.ClubBookings
{
    public class IndexModel : PageModel
    {
        private readonly TennisPlatformProject.Data.TennisPlatformProjectContext _context;

        public IndexModel(TennisPlatformProject.Data.TennisPlatformProjectContext context)
        {
            _context = context;
        }

        public IList<Bookings> Bookings { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Bookings != null)
            {
                Bookings = await _context.Bookings.ToListAsync();
            }
        }
    }
}
