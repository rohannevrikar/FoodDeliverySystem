using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        Task AddItemAsync(T item);
        Task DeleteItemAsync(string id);
        Task<T> GetItemAsync(string id);
        Task UpdateItemAsync(string id, T item);
    }
}
