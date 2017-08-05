using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HWAssignment.Models
{
    public class UserDbContext: DbContext
    {
        public DbSet<User> userAccount { get;  set}


    }
}