using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace intex2.Pages
{
    [Authorize(Roles = "Researcher")]
    public class ResearchPageModel : PageModel
    {


    }
}
