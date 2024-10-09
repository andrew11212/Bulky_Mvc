﻿using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepositery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly ApplicationDBContext context;
		public ICategoryRepository CategoryRepository { get; private set; }

		public IProductRepository ProductRepository { get; private set; }

		public ICompanyRepository CompanyRepository { get; private set; }

		public UnitOfWork(ApplicationDBContext context)
		{
			this.context = context;
			CategoryRepository = new CategoryRepository(context);

			ProductRepository = new ProductRepository(context);

			CompanyRepository = new CompanyRepository(context);
		}
		public void Save()
		{
			context.SaveChanges();
		}

	}
}
