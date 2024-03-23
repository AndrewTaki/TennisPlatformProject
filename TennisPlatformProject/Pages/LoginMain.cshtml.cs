using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TennisPlatformProject.Pages
{
    public class LoginMainModel : PageModel
    {
        private readonly ILogger<LoginMainModel> _logger;
        public bool HideNavigation { get; set; } = true;
        public LoginMainModel(ILogger<LoginMainModel> logger)
        {
            _logger = logger;
        }


        public void OnGet()
        {
            HideNavigation = false; // Set to true to hide navigation
        }
    }
}