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
    public class AddBurialModel : PageModel
    {
        private MummyDBContext context { get; set; }

        public AddBurialModel(MummyDBContext ctx)
        {
            context = ctx;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost(BurialId burialId, BurialCharacteristic burialCharacteristic, BurialNote burialNote, RemainsCharacteristic remainsCharacteristic)
        {
            // using the information from the form, concatenate the BurialId1
            string burId = burialId.BurialLocationNs + " " + burialId.LowPairNs + "/" + burialId.HighPairNs + " " +
                           burialId.BurialLocationEw + " " + burialId.LowPairEw + "/" + burialId.HighPairEw + "  " +
                           burialId.BurialArea + "# " + burialId.BurialNum;

            // set each model item's burial ID value to the concatenated burId
            burialId.BurialId1 = burId;
            burialCharacteristic.BurialId = burId;
            burialNote.BurialId = burId;
            remainsCharacteristic.BurialId = burId;

            // if the objects are valid, save them to the db context
            if (ModelState.IsValid)
            {
                context.BurialIds.Add(burialId);
                context.BurialCharacteristics.Add(burialCharacteristic);
                context.BurialNotes.Add(burialNote);
                context.RemainsCharacteristics.Add(remainsCharacteristic);

                context.SaveChanges();

                return RedirectToPage("./BurialConfirmation", burialId);
            }
            else
            {
                return Page();
            }


        }
    }
}