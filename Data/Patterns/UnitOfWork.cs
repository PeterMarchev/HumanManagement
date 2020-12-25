using NHibernate;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HumanManagement.Data.Patterns
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ISessionFactory _sessionFactory;
        private ISession _session;
        private ITransaction _transaction;
        private readonly Dictionary<Type, object> _repositories;

        public UnitOfWork(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
            _session = _sessionFactory.OpenSession();

            _repositories = new Dictionary<Type, object>();
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            if (_repositories.TryGetValue(typeof(TEntity), out object repo))
                return repo as IRepository<TEntity>;

            var repository = new Repository<TEntity>(_session);
            _repositories.Add(typeof(TEntity), repository);
            return repository;
        }
        
        public void BeginTransaction()
        {
            if (_transaction != null)
                throw new InvalidOperationException("A transaction already exists in this session");
            if (_session == null)
                _session = _sessionFactory.OpenSession();
            _transaction = _session.BeginTransaction();
        }

        public void Commit()
        {
            if (!_transaction.IsActive)
                throw new InvalidOperationException("There are NO active transactions");
            _transaction.Commit();
            Dispose();

        }

        public Task CommitAsync()
        {
            if (!_transaction.IsActive)
                throw new InvalidOperationException("There are NO active transactions");
            return _transaction.CommitAsync();
        }

        public void Rollback()
        {
            if (_transaction.IsActive)
                _transaction.Rollback();
        }

        public Task RollbackAsync()
        {
            if (_transaction.IsActive)
                return _transaction.RollbackAsync();
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            if (_transaction != null)
            {
                Rollback();
                _transaction.Dispose();
                _transaction = null;
            }

            if (_session != null)
            {
                _session.Dispose();
                _session = null;
            }

          
            if (_repositories != null)
            {
                _repositories.Clear();
            }
        }

    }
}
