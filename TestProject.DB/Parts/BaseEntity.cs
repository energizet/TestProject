using System;

namespace TestProject.DB.Parts
{
	public abstract class BaseEntity
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
	}
}