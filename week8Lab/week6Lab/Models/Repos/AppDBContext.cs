
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using week6Lab.Models.Messages;

namespace week6Lab.Models.Repos
{
	public class AppDBContext : DbContext
	{ 
		public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
		public DbSet<Message> DBMessage { get; set; }
		public DbSet<User> DBUser { get; set; }

	}
}
