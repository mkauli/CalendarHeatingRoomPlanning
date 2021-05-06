using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authentication;
using CalendarHeatingRoomPlanning;

namespace CalendarHeatingRoomPlanningUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration _configuration;

        [BindProperty]
        public string UserName { get; set; }
        [BindProperty, DataType(DataType.Password)]
        public string Password { get; set; }
        public string Message { get; set; }

        public IndexModel(IConfiguration configuration, ILogger<IndexModel> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if(Authentification.Instance.IsAuthentificated(HttpContext))
            {
                Authentification.Instance.SetLoginStatus(HttpContext, false);
                return Page();
            }

            var user = _configuration.GetSection("SiteUser").Get<SiteUser>();

            Authentification.Instance.SetLoginStatus(HttpContext, false);
            if (UserName == user.UserName)
            {
                var passwordHasher = new Microsoft.AspNetCore.Identity.PasswordHasher<string>();
                if (passwordHasher.VerifyHashedPassword(null, user.Password, Password) == Microsoft.AspNetCore.Identity.PasswordVerificationResult.Success)
                {
                    var claims = new List<System.Security.Claims.Claim>
                    {
                        new System.Security.Claims.Claim(System.Security.Claims.ClaimTypes.Name, UserName)
                    };
                    var claimsIdentity = new System.Security.Claims.ClaimsIdentity(claims, Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationDefaults.AuthenticationScheme);
                    await HttpContext.SignInAsync(Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationDefaults.AuthenticationScheme, new System.Security.Claims.ClaimsPrincipal(claimsIdentity));
                    Authentification.Instance.SetLoginStatus(HttpContext, true);
                    return RedirectToPage("Index"); 
                }
            }
            Message = "Invalid attempt";
            return Page();
        }
    }
}
