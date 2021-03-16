using System.Threading.Tasks;
using System.Collections.Generic;
using WebApplication.Api.Models;

namespace WebApplication.Logic.Interfaces
{
    public interface IWorkerService
    {
        Task<Worker> GetAsync(int id);
        Task<IEnumerable<Worker>> GetAllAsync();
        Task<Worker> AddAsync(Worker worker);
        Task DeleteAsync(int id);
        Task<Worker> UpdateAsync(Worker worker);
    }
}
