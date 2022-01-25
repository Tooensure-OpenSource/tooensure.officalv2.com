using System.Collections.Generic;
using System.Threading.Tasks;
using TooensureApp.Services.IService;

namespace TooensureApp.Services
{
    public abstract class GenericSerivce<T> : IGenericService<T> where T : class
    {
        public abstract string connectionString { get; }

        public abstract Task<IEnumerable<T>> GetAll();

        public abstract Task<T> GetById(int id);
    }
}