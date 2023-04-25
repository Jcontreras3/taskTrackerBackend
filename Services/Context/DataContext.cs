using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using taskTrackerBackend.Models;

namespace taskTrackerBackend.Services.Context
{
    public class DataContext : DbContext
    {
         public DbSet<UserModel> UserInfo { get; set; }

 

        //    public DbSet<CreateAccountDTO> CreateAccountInfo { get; set; }

        //    public DbSet<LoginDTO> LoginInfo { get; set; }

        //   public DbSet<PasswordDTO> PasswordInfo { get; set; }

        //   public DbSet<UserIdDTO> UserInfo { get; set; }

       public DbSet<AdminLoginDTO> AdminLoginInfo { get; set; }


//constructor below
public DataContext(DbContextOptions options): base(options)
{}

protected override void OnModelCreating(ModelBuilder builder){
    base.OnModelCreating(builder);
}

 }
}