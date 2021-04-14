using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using intex2.Models;

namespace intex2.Controllers
{
    public class UsersController : Controller
    {
        private readonly ILogger<UsersController> _logger;

        private MummyDBContext context { get; set; }

        public UsersController(ILogger<UsersController> logger, MummyDBContext ctx)
        {
            _logger = logger;
            context = ctx;
        }

        [HttpGet]
        public IActionResult AddBurial()
        {
            return View("test");
        }

        [HttpPost]
        public IActionResult AddBurial(BurialId burialId, BurialCharacteristic burialCharacteristic, BurialNote burialNote, RemainsCharacteristic remainsCharacteristic)
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
            if(ModelState.IsValid)
            {
                context.BurialIds.Add(burialId);
                context.BurialCharacteristics.Add(burialCharacteristic);
                context.BurialNotes.Add(burialNote);
                context.RemainsCharacteristics.Add(remainsCharacteristic);

                context.SaveChanges();

                return View("Confirmation", burialId);
            }
            else
            {
                return View();
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
