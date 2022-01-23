﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestProject.DB.Controllers
{
	interface IDbController<T>
	{
		public Task<IEnumerable<T>> GetAll();

		public Task<T> Get(Guid id);

		public Task<T> Insert(T item);

		public Task<T> Update(T item);

		public Task<bool> Delete(Guid id);
	}
}
