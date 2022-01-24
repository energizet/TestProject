using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.View.Models;

namespace TestProject.WinForm
{
	public static class Extentions
	{
		public static string ToString(this Developer developer)
		{
			return developer.Name;
		}
	}
}
