using eTicketsMovie.Data.Base;
using eTicketsMovie.Models;

namespace eTicketsMovie.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {
        }
    }
}
