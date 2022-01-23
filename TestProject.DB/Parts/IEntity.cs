using System;

namespace TestProject.DB.Parts
{
	public abstract class IEntity
	{
		public Guid Id { get; set; }
	}
}