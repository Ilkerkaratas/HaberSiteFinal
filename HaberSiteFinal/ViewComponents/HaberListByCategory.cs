using HaberSiteFinal.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberSiteFinal.ViewComponents
{
    public class HaberListByCategory : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {


            HaberRepository haberRepository = new HaberRepository();
            var haberlist = haberRepository.List(x => x.CategoryID == id);
            return View(haberlist);
        }
    }
}
