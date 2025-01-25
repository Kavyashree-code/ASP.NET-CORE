using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using proj1.Model;

namespace proj1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IPersonalInfoRepository _personalInfo;

        public IndexModel(IPersonalInfoRepository personalInfo)
        {
            _personalInfo=personalInfo;
        }

        public void OnGet()
        {
            ViewData["name"]=_personalInfo.GetPersonalInfo().Name;
            ViewData["phonenumber"] = _personalInfo.GetPersonalInfo().PhoneNumber;
        }
    }
}
