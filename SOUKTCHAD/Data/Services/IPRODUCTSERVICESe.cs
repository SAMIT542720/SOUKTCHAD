using SOUKTCHAD.Data.Base;
using SOUKTCHAD.Data.ModelViews;
using SOUKTCHAD.Models;

namespace SOUKTCHAD.Data.Services
{
    public interface IPRODUCTSERVICESe : IEntityBaseReprository<PRODUCT>
    {
        Task<PRODUCT> GetMovieByIdAsync(int id);
        Task<NewProductDropDownVM> GetNewMovieDropdownsValuesAsync();
        Task AddNewMovieAsync(NewProductVM data);
        Task UpdateMovieAsync(NewProductVM data);
    }
}
