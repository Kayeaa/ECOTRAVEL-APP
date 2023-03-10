﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Entities;

namespace Common.Repositories
{
    public interface IAvisRepository<TEntity, Tid> : IRepository<TEntity, Tid> where TEntity : IAvis
    {

    }
}
