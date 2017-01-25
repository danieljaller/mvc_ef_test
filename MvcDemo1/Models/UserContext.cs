using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcDemo1.Models
{
    public class UserContext : DbContext
    {
        public DbSet<UserModel> UserModels { get; set; }
    }
}