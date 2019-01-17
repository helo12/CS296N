using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using week6Lab.Models.Leaders;
using week6Lab.Models.RecentKills;

namespace week6Lab.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Leaders()
        {
            LeaderViewModel viewModel = new LeaderViewModel();
            return View("Leaders", viewModel);
        }
        public IActionResult RecentKills()
        {
            RecentKillsViewModel Recent = new RecentKillsViewModel();
            return View("RecentKills", Recent);
        }
    }
}