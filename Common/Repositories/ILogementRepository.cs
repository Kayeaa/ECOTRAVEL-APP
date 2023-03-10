using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
        public interface ILogementRepository<TEntity, Tid> : IRepository<TEntity, Tid> where TEntity : ILogement
        {
            IEnumerable<TEntity> GetByTypeLogement(int idTypeLogement);
        }
}
