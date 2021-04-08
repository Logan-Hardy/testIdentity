using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace testIdentity.Pages
{
    [Authorize(Roles = "Admins")]
    public class AdminPageModel : PageModel
    {

    }
}
