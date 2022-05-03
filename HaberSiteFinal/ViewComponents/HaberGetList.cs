using HaberSiteFinal.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberSiteFinal.ViewComponents
{
    public class HaberGetList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            HaberRepository haberRepository = new HaberRepository();
            var haberlist = haberRepository.TList();
            
            return View(haberlist);
        }
    }
}
