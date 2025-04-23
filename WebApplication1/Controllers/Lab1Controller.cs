using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class Lab1Controller : Controller
    {
        public List<string> GetVegetablesList()
        {
            List<string> vegetables = new List<string>();
            vegetables.Add("Томат");
            vegetables.Add("Картофель");
            vegetables.Add("Кабачок");
            vegetables.Add("Баклажан");
            vegetables.Add("Капуста");
            vegetables.Add("Броколи");
            
            return vegetables;
        }
        // GET: Lab1
        public ActionResult FirstViewMethod()
        {
            List<string> vegetables = GetVegetablesList();
            return View(vegetables);
        }
    }
}