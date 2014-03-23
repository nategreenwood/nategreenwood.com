﻿using System.Collections.Generic;
using FunnelWeb.DatabaseDeployer.DbProviders;
using NHibernate;

namespace FunnelWeb.Repositories
{
    public interface IQuery<out TResult>
    {
        IEnumerable<TResult> Execute(ISession session, IDatabaseProvider databaseProvider);
    }
}