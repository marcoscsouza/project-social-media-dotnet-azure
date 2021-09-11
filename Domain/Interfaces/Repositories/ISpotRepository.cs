using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface ISpotRepository
    {
        Task<IEnumerable<SpotModel>> GetAllAsync();
        Task<SpotModel> GetByIdAsync(int id);
        Task CreateAsync(SpotModel spotModel);
        Task EditAsync(SpotModel spotModel);
        Task DeleteAsync(int id);
    }
}
