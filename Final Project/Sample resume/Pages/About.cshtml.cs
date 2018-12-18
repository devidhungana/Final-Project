using Microsoft.AspNetCore.Mvc.RazorPages;

namespace sampleResume.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Thank You for your visit.";
        }
        
    }
}
