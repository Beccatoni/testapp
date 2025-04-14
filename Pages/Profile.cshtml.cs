using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestApp.Pages;

public class Profile : PageModel
{
    public void OnGet()
    {
        ViewData["myName"] = "Rebecca Mutoni";
        ViewData["username"] = "Beccatoni";
        ViewData["myOccupation"] = "A junior software developer";
        ViewData["myAge"] = 25;
        ViewData["currentDate"] = "04/14/25";        
    }
}