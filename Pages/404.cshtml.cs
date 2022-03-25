using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SecureCloud.Pages
{
    public class PageNotFoundModel : PageModel
    {

        private readonly ILogger<PageNotFoundModel> _logger;
        public PageNotFoundModel(ILogger<PageNotFoundModel> logger)
        {

            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}