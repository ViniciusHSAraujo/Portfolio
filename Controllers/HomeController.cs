﻿using Microsoft.AspNetCore.Mvc;

namespace Portfólio.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }

        public IActionResult About() {
            return View();
        }

        public IActionResult Skills() {
            return View();
        }

        public IActionResult Projects() {
            return View();
        }

        public IActionResult Contact() {
            return View();
        }
    }
}
