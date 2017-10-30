﻿using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Bayetech.Service.Interface
{
    public interface IBaseService1<TEntity>
    {
        int Insert(JObject json);
        int Update(JObject json);
        int Delete(object keyValue);
        TEntity FindEntity(object keyValue);

        IQueryable<TEntity> FindList(Expression<Func<TEntity, bool>> predicate);

        
    }
}
