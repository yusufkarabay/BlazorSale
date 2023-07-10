using Core.DB.Helper;
using Core.DB.Interfaces;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DB.Manager
{
    public class RepositoryManager<T> : IRepositoryService<T> where T : class, IEntity, new()
    {
        private readonly NhibernateHelper _nHibernateHelper;

        public RepositoryManager(NhibernateHelper nHibernateHelper)
        {
            _nHibernateHelper=nHibernateHelper;
        }

        public List<T> GetList(Expression<Func<T, bool>> filter = null)
        {
            using(var session = _nHibernateHelper.OpenSession())
            {
                return filter == null
                    ? session.Query<T>().ToList()
                    : session.Query<T>().Where(filter).ToList();
            }
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            using(var session = _nHibernateHelper.OpenSession())
            {
                return session.Query<T>().SingleOrDefault(filter);
            }
        }

        public T Add(T entity)
        {
            using(var session = _nHibernateHelper.OpenSession())
            {
                session.Save(entity);
                return entity;
            }
        }

        public T Update(T entity)
        {
            using(var session = _nHibernateHelper.OpenSession())
            {
                session.Update(entity);
                return entity;
            }
        }

        public void Delete(T entity)
        {
           using(var session = _nHibernateHelper.OpenSession())
            {
                session.Delete(entity);
                session.Flush();
                session.Clear();
            }
        }
    }
    
}
