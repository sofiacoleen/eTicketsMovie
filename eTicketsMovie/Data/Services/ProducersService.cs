using eTicketsMovie.Data.Base;
using eTicketsMovie.Models;

namespace eTicketsMovie.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
        }
    }
}
