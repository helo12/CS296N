using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaelumNavis.Models
{
	public class PledgeRepo
	{
		private List<Pledge> Pledge = new List<Pledge>();
		public List<Pledge> Pledges { get { return Pledge; } }

		public PledgeRepo()
		{
			AddTestData();
		}
		public void AddPledge(Pledge pledge)
		{
			Pledge.Add(pledge);
		}
		public void DeletePledge(Pledge pledge)
		{
			foreach (Pledge pldg in Pledges)
			{
				if (pldg.customer.Name == pledge.customer.Name)
				{
					Pledges.Remove(pledge);
				}
			}
		}
		//TODO after Entity set up
		public void UpdatePledge(Pledge pledge)
		{

		}

		public Pledge GetPledgeByName(string Name)
		{
			Pledge leader = Pledges.Find(b => b.customer.Name == Name);
			return null;
		}
		void AddTestData()
		{
			Pledges.Add(new Pledge() { CardNum="1234", ExpirationDate="10/19" });
		}
	}
}
