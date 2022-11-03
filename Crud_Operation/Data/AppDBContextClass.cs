using Crud_Operation.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_Operation.Data
{
    public class AppDBContextClass : DbContext
    {
        public AppDBContextClass(DbContextOptions options) : base(options)
        {

        }

        public DbSet<VenderMaster> venderMasters { get; set; }
    }
}
