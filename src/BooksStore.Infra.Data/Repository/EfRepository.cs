﻿using Ardalis.Specification.EntityFrameworkCore;
using BooksStore.Infra.Data.Context;
using BooksStore.SharedKernel.Interfaces;

namespace BooksStore.Infra.Data.Repository;

public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
{
  public EfRepository(AppDbContext dbContext) : base(dbContext)
  {
  }
}
