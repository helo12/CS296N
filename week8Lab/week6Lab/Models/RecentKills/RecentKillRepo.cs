using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week6Lab.Models
{
	public class RecentKillRepo
	{
        public List<RecentKill> RecentKills { get; set; }

		public RecentKillRepo()
		{
            RecentKills = new List<RecentKill>();
			AddTestData();
		}
		public  void AddRecentKill(RecentKill recentKill)
		{
			RecentKills.Add(recentKill);
		}
		public RecentKill GetLeaderByFname(string Name)
		{
			RecentKill RecentKill = RecentKills.Find(b => b.Name == Name);
			return RecentKill;
		}
		 void AddTestData()
		{
            AddRecentKill(new RecentKill() { Name = "Test Leader", Link = "https://evewho.com/pilot/helo+erebus" });
		}
	}
}
