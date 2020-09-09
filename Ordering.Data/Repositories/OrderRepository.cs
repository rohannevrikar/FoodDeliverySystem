using Microsoft.Azure.Cosmos;
using Ordering.Data.Infrastructure;
using Ordering.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ordering.Data.Repositories
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(CosmosClient dbClient, string databaseName, string containerName) : base(dbClient, databaseName, containerName)
        {

        }
    }
    public interface IOrderRepository : IRepository<Order>
    {

    }
}
