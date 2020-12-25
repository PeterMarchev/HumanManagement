﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HumanManagement.Data.Patterns
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Entity { get; }
        void AddRange(IEnumerable<TEntity> rangeList);
        Task AddRangeAsync(IEnumerable<TEntity> rangeList);
        string AddItem(TEntity item);
        Task<string> AddItemAsync(TEntity item);

        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null,
                          Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                          Func<IQueryable<TEntity>, IQueryable<TEntity>> fetch = null);
        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null,
                                     Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                                     Func<IQueryable<TEntity>, IQueryable<TEntity>> fetch = null);

        TEntity GetSingle(Expression<Func<TEntity, bool>> filter,
                               Func<IQueryable<TEntity>, IQueryable<TEntity>> fetch = null);

        Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> filter,
                                Func<IQueryable<TEntity>, IQueryable<TEntity>> fetch = null);
        TEntity GetById(object id);
        Task<TEntity> GetByIdAsync(object id);

        void Update(TEntity item);
        Task UpdateAsync(TEntity item);

        void Delete(TEntity item);
        Task DeleteAsync(TEntity item);
    }
}
