using eTicketsMovie.Data.Base;
using eTicketsMovie.Models;
using Microsoft.EntityFrameworkCore;

namespace eTicketsMovie.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }
}