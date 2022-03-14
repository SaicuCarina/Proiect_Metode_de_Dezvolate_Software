using IndividualProject;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WAD.Business;

namespace WAD.Pages
{
    public class LogInPageModel : PageModel
    {
        [BindProperty]
        public User UserInfo { get; set; }
        Administration administration = new Administration();
        LoginAdministration loginAdministration = new LoginAdministration();
        Login login = new Login();
        public void OnGet()
        {
            

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                if(loginAdministration.VerifyLogin(UserInfo.Email, UserInfo.Password))
                    return RedirectToPage("Index"); 
            }
            return RedirectToPage("ProfilePage");
        }
        
    }
}
