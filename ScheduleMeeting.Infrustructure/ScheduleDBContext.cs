using Microsoft.EntityFrameworkCore;
using ScheduleMeeting.Entity;
using System;

namespace ScheduleMeeting.Infrustructure
{
    public class ScheduleDBContext : DbContext
    {
        public ScheduleDBContext(DbContextOptions<ScheduleDBContext> options) : base(options)
        { }

        public DbSet<City> Citys { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Country> Countrys { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
