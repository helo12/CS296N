using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using week6Lab.Models.Leaders;

namespace week6Lab.Models.Leaders
{
    public class LeaderViewModel
    {
        public LeaderRepo LeaderRepo;
        public Leader Leader;
        public LeaderViewModel()
        {
            LeaderRepo = new LeaderRepo();
            Leader = new Leader();
        }
    }
}
