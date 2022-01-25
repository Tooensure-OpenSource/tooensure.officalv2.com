using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TooensureApp.Models.BlogModel;

namespace TooensureApp.Services.IService
{
    public interface IGenericService<T> where T : class
    {
        string connectionString { get; }
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
    }
}