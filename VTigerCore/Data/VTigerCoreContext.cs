using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VTigerCore.Models;

namespace VTigerCore.Models
{
    public class VTigerCoreContext : DbContext
    {
        public VTigerCoreContext (DbContextOptions<VTigerCoreContext> options)
            : base(options)
        {
        }

        public DbSet<VTigerCore.Models.Product> Product { get; set; }

        public DbSet<VTigerCore.Models.User> User { get; set; }
    }
}
