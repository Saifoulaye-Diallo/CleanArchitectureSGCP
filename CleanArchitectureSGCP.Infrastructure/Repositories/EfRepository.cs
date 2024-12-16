using CleanArchitectureSGCP.SharedKernel;
using CleanArchitectureSGCP.SharedKernel.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CleanArchitectureSGCP.Infrastructure.Repositories
{
    public class EfRepository<T> : IAsyncRepository<T>, IRepository<T> where T : BaseEntity, IAggregateRoot
    {
        protected readonly SGCPContext _Sgcpcontext;
        public EfRepository(SGCPContext sgcpcontext)
        {
            _Sgcpcontext = sgcpcontext;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _Sgcpcontext.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _Sgcpcontext.Set<T>().ToListAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            await _Sgcpcontext.Set<T>().AddAsync(entity);
            await _Sgcpcontext.SaveChangesAsync();
            return entity;

        }

        public async Task UpdateAsync(T entity)
        {
            _Sgcpcontext.Entry(entity).State = EntityState.Modified;

            await _Sgcpcontext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _Sgcpcontext.Set<T>().Remove(entity);

            await _Sgcpcontext.SaveChangesAsync();
        }
        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return
            SpecificationEvaluator<T>.GetQuery(
              _Sgcpcontext.Set<T>().AsQueryable(), spec);
        }

        public async Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).ToListAsync();
        }

        public async Task<int> CountAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).CountAsync();
        }

        public T GetById<T>(int id) where T : BaseEntity
        {
            return _Sgcpcontext.Set<T>().Find(id);
        }

        public List<T> List<T>() where T : BaseEntity
        {
            return _Sgcpcontext.Set<T>().ToList();
        }

        public T Add<T>(T entity) where T : BaseEntity
        {
            _Sgcpcontext.Set<T>().Add(entity);
            _Sgcpcontext.SaveChanges();
            return entity;

        }

        public void Update<T>(T entity) where T : BaseEntity
        {
            _Sgcpcontext.Entry(entity).State = EntityState.Modified;

            _Sgcpcontext.SaveChanges();
        }

        public void Delete<T>(T entity) where T : BaseEntity
        {
            _Sgcpcontext.Set<T>().Remove(entity);

            _Sgcpcontext.SaveChanges();
        }
    }
}
