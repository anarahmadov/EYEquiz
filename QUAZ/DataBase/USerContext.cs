using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAZ.DataBase
{
    class UserContext : DbContext
    {
        public DbSet<QUAZ.Model.User> Users { get; set; }

        public UserContext() : base("UserDb")
        {
            
        }
    }
}
