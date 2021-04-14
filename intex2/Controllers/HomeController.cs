using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using intex2.Models;
using intex2.Models.ViewModels;

namespace intex2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private MummyDBContext context { get; set; }

        public HomeController(ILogger<HomeController> logger, MummyDBContext ctx)
        {
            _logger = logger;
            context = ctx; 
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MomiasDatabase()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Gallery()
        {
            return View();
        }

        public IActionResult Search(bool male, bool female, bool black, bool blonde, bool brown, int? depth, int PageNum = 1)
        {
            int PageSize = 15;

            return View(new IndexViewModel
            {
                Remains = context.RemainsCharacteristics
                .Where(s => male == true ? s.GenderBodyCol == "M" : true)
                .Where(s => female == true ? s.GenderBodyCol == "F" : true)
                .Where(s => black == true ? s.HairColor == "black" : true)
                .Where(s => blonde == true ? s.HairColor == "blonde" : true)
                .Where(s => brown == true ? s.HairColor == "brown" : true)
                .OrderBy(p => p.BurialId)
                .Skip((PageNum - 1) * PageSize)
                .Take(PageSize)
                .ToList(),

                Burials = context.BurialCharacteristics
                .Where(s => depth <= 1 ? s.DepthRemains <= 1: true)
                .Where(s => depth <= 2 ? s.DepthRemains <= 2  : true)
                .Where(s => depth <= 3 ? s.DepthRemains <= 3 : true)
                .Where(s => depth <= 4 ? s.DepthRemains <= 4 : true)
                .Where(s => depth <= 5 ? s.DepthRemains <= 5 : true)
                .Where(s => depth > 5 ? s.DepthRemains > 5 : true)
                .ToList(),

                pageNum = new PageNum
                {
                    NumPerPage = PageSize,
                    CurrentPage = PageNum,
                    TotalNumItems = ((male == false & female == false & black == false & blonde == false & brown == false & depth == null)? context.RemainsCharacteristics.Count()
                    : context.RemainsCharacteristics.Where(x => x.GenderBodyCol == "M" 
                    || x.GenderBodyCol == "F"
                    || x.HairColor == "black"
                    || x.HairColor =="blonde"
                    || x.HairColor == "brown").Count())
                }

            });
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Mummy(string Id)
        {
            return View(new MummyViewModel
            {
                Remains = context.RemainsCharacteristics
                .Where(r => r.BurialId == Id)
                .ToList(),

                Burials = context.BurialCharacteristics
                .Where(r => r.BurialId == Id)
                .ToList(),

                Biologicals = context.BiologicalSamples
                .Where(r => r.BurialId == Id)
                .ToList(),

                Ids = context.BurialIds
                .Where(r => r.BurialId1 == Id)
                .ToList(),

                Artifacts = context.Artifacts
                .Where(r => r.BurialId == Id)
                .ToList(),

                Notes = context.BurialNotes
                .Where(r => r.BurialId == Id)
                .ToList(),
            });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
