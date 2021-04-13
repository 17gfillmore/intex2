using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;


namespace intex2.Pages
{
    [Authorize(Roles="Admins")]
    public class AdminPageModel : PageModel
    {
    }
}

//The Authorize attribute can be applied without arguments, which restricts access to any authenticated user. The Roles
//argument is used to further restrict access to users who are members of specific roles, which are expressed as a comma-separated 
//list. The attribute in this listing restricts access to users assigned to the Admins role. The authorization restrictions are inherited,
//which means that applying the attribute to the base class restricts access to all the Razor Pages created to manage users and roles