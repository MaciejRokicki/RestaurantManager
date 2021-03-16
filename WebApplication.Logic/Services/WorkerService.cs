using System.Threading.Tasks;
using System.Collections.Generic;
using WebApplication.Api.Models;
using WebApplication.Dal.Repositories.Interfaces;
using WebApplication.Logic.Interfaces;

namespace WebApplication.Logic.Services
{
    public class WorkerService : IWorkerService
    {
        private readonly IWorkerRepository workerRepository;

        public WorkerService(IWorkerRepository workerRepository)
        {
            this.workerRepository = workerRepository;
        }

        public async Task<Worker> AddAsync(Worker worker)
        {
            Worker result = await workerRepository.AddAsync(worker);

            return result;
        }

        public async Task DeleteAsync(int id)
        {
            await workerRepository.DeleteAsync(x => x.Id == id);
        }

        public async Task<Worker> GetAsync(int id)
        {
            Worker result = await workerRepository.GetAsync(x => x.Id == id);

            return result;
        }

        public async Task<IEnumerable<Worker>> GetAllAsync()
        {
            IEnumerable<Worker> result = await workerRepository.GetAllAsync();

            return result;
        }

        public async Task<Worker> UpdateAsync(Worker worker)
        {
            Worker result = await workerRepository.UpdateAsync(worker);

            return result;
        }
    }
}
