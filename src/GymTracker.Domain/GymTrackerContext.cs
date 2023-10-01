using Microsoft.EntityFrameworkCore;

namespace GymTracker.Domain
{
    public class GymTrackerContext : DbContext
    {
        public GymTrackerContext(DbContextOptions<GymTrackerContext> options) : base(options) { }
    }
}
