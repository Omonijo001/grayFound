using grayFoundation.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI;
using System.Diagnostics.Eventing.Reader;

namespace grayFoundation.GrayDbContext
{
    public class GrayContext : DbContext
    {
        public GrayContext(DbContextOptions<GrayContext> database) : base(database)
        {

        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<DonationHistory> DonationHistorys { get; set; }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectDonor> ProjectDonors { get; set; }
        public DbSet<ProjectVolunteer> ProjectVolunteers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }

    }
}
