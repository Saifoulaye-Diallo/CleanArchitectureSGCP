using System.Collections.Generic;
using CleanArchitectureSGCP.SharedKernel;

namespace CleanArchitectureSGCP.SharedKernel.Interfaces
{
    public interface IRepository<in T> where T : BaseEntity, IAggregateRoot
    {
        T GetById<T>(int id) where T : BaseEntity;
        List<T> List<T>() where T : BaseEntity;
        T Add<T>(T entity) where T : BaseEntity;
        void Update<T>(T entity) where T : BaseEntity;
        void Delete<T>(T entity) where T : BaseEntity;
    }
}
