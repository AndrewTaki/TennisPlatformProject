using TennisPlatformProject.Data;
using TennisPlatformProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace TennisPlatformProject.Pages.Login
{
    public class LoginModel : PageModel
    {
        private readonly TennisPlatformProjectContext _context;

        public LoginModel(TennisPlatformProjectContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            if (!string.IsNullOrEmpty(SearchString))
            {
                var clubMember = await _context.ClubMembers.FirstOrDefaultAsync(m => m.Email == SearchString);

                if (clubMember != null)
                {
                    // Email address is correct, redirect to home page or any other page
                    ViewData["LoginSuccessful"] = true;
                    return RedirectToPage("/LoginMain");
                }
                else
                {
                    // Email address is not found, display invalid email message
                    ViewData["InvalidEmailMessage"] = "Invalid email address. Please try again.";
                }
            }

            // No search string provided or email address not found, return the page
            return Page();
        }

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public IList<ClubMembers> ClubMembers { get; set; } = new List<ClubMembers>();
    }
}
