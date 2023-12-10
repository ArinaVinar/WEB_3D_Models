using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using _3DMap.Models;
using Microsoft.AspNetCore.Mvc;
using tyuiu.oop.VinarAI.InteractiveMap.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _3DMap.Controllers
{
    public class MapController : Controller
    {
        // GET: /<controller>/
        public IActionResult floor8()
        {
            var rects = new List<Room>() {
                new Room() { Number="811", X=20, Y=20, Width=60, Height=100 },
                new Room() { Number="816", X=20, Y=140, Width=60, Height=50 },
                new Room() { Number="812", X=20, Y=210, Width=60, Height=130 },
                new Room() { Number="ladder", X=20, Y=360, Width=30, Height=50 },
                new Room() { Number="803", X=100, Y=20, Width=100, Height=100 },
                new Room() { Number="809", X=100, Y=120, Width=70, Height=50 },
                new Room() { Number="x", X=170, Y=120, Width=30, Height=50 },
                new Room() { Number="801", X=200, Y=20, Width=80, Height=60 },
                new Room() { Number="ladder", X=290, Y=20, Width=20, Height=60 },
                new Room() { Number="802", X=310, Y=20, Width=80, Height=60 },
                new Room() { Number="806", X=210, Y=120, Width=60, Height=100 },
                new Room() { Number="808", X=210, Y=220, Width=60, Height=120 },
                new Room() { Number="810", X=80, Y=360, Width=130, Height=50 },
                new Room() { Number="ladder", X=240, Y=360, Width=30, Height=50 },
                new Room() { Number="800", X=210, Y=390, Width=30, Height=20 },
                new Room() { Number="toulet", X=90, Y=280, Width=110, Height=60 },
                new Room() { Number="lift", X=100, Y=250, Width=90, Height=30 },
                new Room() { Number="804", X=390, Y=20, Width=60, Height=100 }
            };
            return View(rects);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}