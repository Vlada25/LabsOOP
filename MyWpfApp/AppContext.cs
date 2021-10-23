using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Text;
using TireFittingLibrary;

namespace MyWpfApp
{
    class AppContext : DbContext
    {
        public DbSet<Repair> Repair { get; set; }

        public AppContext() : base("DBSource")
        {
        }
    }
}
