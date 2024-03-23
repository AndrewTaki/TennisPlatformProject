﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly TennisPlatformProject.Data.TennisPlatformProjectContext _context;

        public DetailsModel(TennisPlatformProject.Data.TennisPlatformProjectContext context)
        {
            _context = context;
        }

      public Bookings Bookings { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Bookings == null)
            {
                return NotFound();
            }

            var bookings = await _context.Bookings.FirstOrDefaultAsync(m => m.Id == id);
            if (bookings == null)
            {
                return NotFound();
            }
            else 
            {
                Bookings = bookings;
            }
            return Page();
        }
    }
}
