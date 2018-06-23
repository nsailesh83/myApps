
using Microsoft.EntityFrameworkCore;
using myAppy1.API.models;

namespace myAppy1.API.data
{
   
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<value> Values {get;set;}

        public DbSet<User> Users {get;set;}

        public DbSet<Photo> Photos {get;set;}
    }
}