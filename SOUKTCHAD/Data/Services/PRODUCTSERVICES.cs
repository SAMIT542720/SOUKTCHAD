using SOUKTCHAD.Data.Base;
using SOUKTCHAD.Data.ModelViews;
using SOUKTCHAD.Models;

namespace SOUKTCHAD.Data.Services
{
    public class PRODUCTSERVICES : EntityBaseRepository<PRODUCT>, IPRODUCTSERVICESe
    {
        private readonly AppDbContext _context;
        public PRODUCTSERVICES(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public Task AddNewMovieAsync(NewProductVM data)
        {
            throw new NotImplementedException();
        }

        public Task<PRODUCT> GetMovieByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<NewProductDropDownVM> GetNewMovieDropdownsValuesAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateMovieAsync(NewProductVM data)
        {
            throw new NotImplementedException();
        }
    }
}
