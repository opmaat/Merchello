﻿using System;
using Merchello.Core.Models;
using Umbraco.Core.Persistence.Repositories;

namespace Merchello.Core.Persistence.Repositories
{
    /// <summary>
    /// Marker interface for the shipiment repository
    /// </summary>
    public interface IShipmentRepository : IRepositoryQueryable<Guid, IShipment>
    {
    }
}
