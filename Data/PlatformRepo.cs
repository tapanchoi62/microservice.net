using PlatformService.Models;

namespace PlatformService.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _context;

        public PlatformRepo(AppDbContext context)
        {
            _context = context;
        }
        void IPlatformRepo.CreatePlatform(Platform plat)
        {
            if(plat == null){
                throw new ArgumentException(nameof(plat));
            }
            _context.Platforms.Add(plat);
        }

        IEnumerable<Platform> IPlatformRepo.GetAllPlatforms()
        {
            return _context.Platforms.ToList();
        }

        Platform IPlatformRepo.GetById(int id)
        {
            return _context.Platforms.FirstOrDefault(x => x.id == id);
        }

        bool IPlatformRepo.SaveChange()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}