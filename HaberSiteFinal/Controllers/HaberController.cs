using HaberSiteFinal.Models;
using HaberSiteFinal.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace HaberSiteFinal.Controllers
{
    public class HaberController : Controller
    {
        Context c = new Context();
        HaberRepository haberRepository = new HaberRepository();

        public IActionResult Index(int page = 1)
        {
            return View(haberRepository.TList("Category").ToPagedList(page, 10));
        }
        [HttpGet]
        public IActionResult AddHaber()
        {
            List<SelectListItem> values = (from x in c.categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            return View();
        }
        [HttpPost]
        public IActionResult AddHaber(HaberEkle p)
        {
            Haber h = new Haber();
            if (p.ImageURL != null)
            {
                var extension = Path.GetExtension(p.ImageURL.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "WWWroot/Resimler/"+ newimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.ImageURL.CopyTo(stream);
                h.ImageURL = newimagename;

            }
            h.HaberName = p.Name;
            h.CategoryID = p.CategoryID;
            h.Description = p.Description;
            haberRepository.TAdd(h);
            return RedirectToAction("Index");


        }

        public IActionResult DeleteHaber(int id)
        {
            haberRepository.TDelete(new Haber { HaberID = id });

            return RedirectToAction("Index");
        }

        public IActionResult HaberGet(int id)
        {
            var x = haberRepository.TGet(id);
            List<SelectListItem> values = (from y in c.categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = y.CategoryName,
                                               Value = y.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            Haber f = new Haber()
            {
                HaberID = x.HaberID,
                CategoryID = x.CategoryID,
                HaberName = x.HaberName,               
                Description = x.Description,
                ImageURL = x.ImageURL
            };
            return View(f);
        }
        [HttpPost]
        public IActionResult HaberUpdate(Haber p)
        {
            var x = haberRepository.TGet(p.HaberID);
            x.HaberName = p.HaberName;            
            x.ImageURL = p.ImageURL;
            x.Description = p.Description;
            x.CategoryID = p.CategoryID;
            haberRepository.TUpdate(x);

            return RedirectToAction("Index");
        }
    }
}
