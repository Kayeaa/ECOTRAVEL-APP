using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Entities;

namespace Common.Repositories
{
    public interface IReservationRepository<TEntity, TId> : IRepository<TEntity, TId> where TEntity : IReservation
    {
        IEnumerable<TEntity> GetByClient(int idClient);
        IEnumerable<TEntity> GetByDate(DateTime date);
    }
}
