using eTicketsMovie.Data.Base;
using eTicketsMovie.Data.ViewModels;
using eTicketsMovie.Models;

namespace eTicketsMovie.Data.Services
{
    public interface IMoviesService: IEntityBaseRepository<Movie>

    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
    }
}
