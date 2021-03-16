using System.Collections.Generic;
using WebApplication.Api.Models;
using WebApplication.Commons.GenericRepository;
using WebApplication.Dal.Repositories.Interfaces;

namespace WebApplication.Dal.Repositories
{
    public class WorkerRepository : GenericRepository<Worker>, IWorkerRepository
    {
        private readonly RestaurantManagerContext restaurantManagerContext;

        public WorkerRepository(RestaurantManagerContext restaurantManagerContext) : base(restaurantManagerContext)
        {
            this.restaurantManagerContext = restaurantManagerContext;
        }
    }
}
