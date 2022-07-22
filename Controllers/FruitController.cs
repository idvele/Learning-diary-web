using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningDiary_IK0._1.Controllers
{
    public class FruitController : Controller
    {
        public IActionResult Index()
        {
            return View();
           
        }
    }
}
