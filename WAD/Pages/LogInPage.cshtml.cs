using IndividualProject;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WAD.Pages
{
    public class LogInPageModel : PageModel
    {
        [BindProperty]
        public User UserInfo{ get; set; }
        Administration administration = new Administration();
        Login login = new Login();
        public void OnGet()
        {
            

        }

        public IActionResult OnPost()
        {
            if (administration.IsInDatabase(UserInfo.Email) == true)
            {
                if (administration.VerifyCredentials(UserInfo.Email, UserInfo.Password) == true)
                {
                    return RedirectToPage("/Index");
                }
            }
            return Page();
        }
        
    }
}
