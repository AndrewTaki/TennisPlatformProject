using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TennisPlatformProject.Models;

namespace TennisPlatformProject.Data
{
    public class TennisPlatformProjectContext : DbContext
    {
        public TennisPlatformProjectContext (DbContextOptions<TennisPlatformProjectContext> options)
            : base(options)
        {
        }

        public DbSet<TennisPlatformProject.Models.Bookings> Bookings { get; set; } = default!;

        public DbSet<TennisPlatformProject.Models.ClubMembers> ClubMembers { get; set; } = default!;
    }
}
