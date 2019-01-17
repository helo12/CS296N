using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week6Lab.Models.RecentKills
{
    public class RecentKillsViewModel
    {
        public RecentKillRepo recentKillRepo;
        public RecentKill recentKill; 

        public RecentKillsViewModel()
        {
            recentKillRepo = new RecentKillRepo();
            recentKill = new RecentKill();
        }
    }
}
