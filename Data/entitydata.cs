using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SyamDatingAppV_1.Entities;
using System.Data.SqlClient;
//using Microsoft.EntityFrameworkCore.Tools;
using Microsoft.EntityFrameworkCore.SqlServer;



namespace SyamDatingAppV_1.Data
{
    public class entityData:DbContext
    {


        public entityData(DbContextOptions options): base(options)
        {
            Database.EnsureCreated();
           
        }

       
        public DbSet<AppUser> User { get; set; }

       

    }
}
