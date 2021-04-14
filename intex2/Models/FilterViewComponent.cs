using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using intex2.Models;
using intex2.Models.ViewModels;

namespace intex2.Components
{
    public class FilterViewComponent : ViewComponent
    {
        private MummyDBContext context;

        public FilterViewComponent (MummyDBContext ctx)
        {
            context = ctx;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedName = RouteData?.Values["burialnum"];

            return View(context.RemainsCharacteristics
                .Distinct()
                .OrderBy(x => x.GenderGe)
                .ToList());
        }
    }
}
