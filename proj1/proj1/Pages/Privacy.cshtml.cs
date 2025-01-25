using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using proj1.Model;

namespace proj1.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly IPersonalInfoRepository _personalInfo;

        public PrivacyModel(IPersonalInfoRepository personalInfo)
        {
            _personalInfo = personalInfo;
        }

        public void OnGet()
        {
            ViewData["a"] = _personalInfo.GetPersonalInfo().RollNo;
        }
    }

}
