using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
    public interface IProprietaireRepository <TEntity, Tid> : IGetRepository<TEntity, Tid>, IDeleteRepository<TEntity, Tid> where TEntity : IProprietaire
    {
        Tid Insert(Tid id);
    }
}
