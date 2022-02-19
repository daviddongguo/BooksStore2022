﻿using Ardalis.Specification;

namespace BooksStore.SharedKernel.Interfaces;

public interface IRepository<T> : IRepositoryBase<T> where T : BaseEntity, IAggregateRoot
{
}
