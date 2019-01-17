using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week6Lab.Models.Leaders
{
	public class LeaderRepo
	{
		public  List<Leader> leaders = new List<Leader>();
		public  List<Leader> Leaders { get { return Leaders; } }

		 public LeaderRepo()
		{
			AddTestData();
		}
		public  void AddLeader(Leader leader)
		{
			leaders.Add(leader);
		}
		public  Leader GetLeaderByFname(string Name)
		{
			Leader leader = leaders.Find(b => b.Name == Name);
			return null;
		}
		 void AddTestData()
		{
			leaders.Add(new Leader() { Name = "Test Leader", Link = "https://evewho.com/pilot/helo+erebus" });
		}
	}
}
