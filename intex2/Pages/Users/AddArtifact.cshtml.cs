using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using intex2.Models;
using Microsoft.AspNetCore.Identity;
using intex2.Pages;
using intex2.Pages.Users;

namespace intex2.Pages.Users
{
    public class AddArtifactModel : PageModel
    {
        private MummyDBContext context { get; set; }

        public AddArtifactModel(MummyDBContext ctx)
        {
            context = ctx;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost(Artifact artifact)
        {
            // if the artifact object is valid, save it to the db context
            if (ModelState.IsValid)
            {
                context.Artifacts.Add(artifact);
                context.SaveChanges();

                return RedirectToPage("./ArtifactConfirmation", artifact);
            }
            else
            {
                return Page();
            }


        }
    }
}