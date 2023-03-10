using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Entities;

namespace Common.Repositories
{
    public interface IClientRepository<TEntity, Tid> : IRepository<TEntity, Tid> where TEntity : IClient
    {
        int? CheckPassword(string CliEmail, string CliPassword);
    }
}
