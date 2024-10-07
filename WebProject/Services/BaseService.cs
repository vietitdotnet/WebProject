using WebProject.DbContextLayer;

namespace WebProject.Services
{
    public class BaseService
    {
       
        protected readonly AppDbContext _context;

        public BaseService(AppDbContext context)
        {
            _context = context;
        }
        
    }
}
