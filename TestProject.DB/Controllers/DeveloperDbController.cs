using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestProject.DB.Models;
using TestProject.View.Models;

namespace TestProject.DB.Controllers
{
	class DeveloperDbController : DbController<Developer>
	{
		protected override DbSet<Developer> Entities => Db.Entities.Developers;
	}
}
