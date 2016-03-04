
using BulkaSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BulkaSite.Controllers
{
    public class BreadController : Controller
    {
        // GET: Bread
        public ActionResult About()
        {
            return View();
        }
    public ActionResult Receipy()
    {
      Bread[] breadList = { new Bread {Name="Бородинский",Receipt="рецепт1" },
        new Bread {Name="Шведский",Receipt="рецепт2" },
        new Bread {Name="Подовый",Receipt="рецепт3" } };
      
      return View(breadList);
    }

    public ActionResult RandomFact()
    {
      //var breadFact = "Типичная для Челябинска фраза - Дайте мне булку хлеба может поставить" +
      //  "в тупик продавца любой питерской булочной";
      return View();
    }
  }
}