using Microsoft.AspNetCore.Mvc.RazorPages;

namespace sampleResume.Pages
{
    public class ResumeModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
            Message = "Thank You for visiting this page! Have a great Day.";
        }
    }
}