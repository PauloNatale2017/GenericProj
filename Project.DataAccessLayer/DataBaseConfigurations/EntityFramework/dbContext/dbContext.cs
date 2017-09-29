using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Data.Entity.Migrations.Model.UpdateDatabaseOperation;

namespace Project.DataAccessLayer.DataBaseConfigurations.EntityFramework.dbContext
{
    public class dbContext : DbContext
    {
        public dbContext() : base("name=ConnectionEntity") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {                
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
