using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Context
{
    public class ApplicationDBContext : DbContext
    {





        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<decimal>().HavePrecision(18, 2);


        }

        public override void int SaveChanges()
        { EnsureAudit();
            return base.SaveChanges();
        }

        public override void Task<int>SaveChangesAsync(bool acceptAllChangesOnSucces, CancellationToken cancellationToken= default)
        {
            EnsureAudit();
            return base.SaveChangesAsync(acceptAllChangesOnSucces, CancellationToken);
        }

        public async Task<IEnumerable>> QueryAsync<T>(String text, object parameters, timeout, Type, CancellationToken.None);
        var connection = DatabaseGeneratedAttribute.GetDbConnection(); 
        return await connection.QueryAsync<T>(command.Definition); }

    private void EnsureAudit()
    {
        ChangeTracker.DetectChanges();
    }

    public DbSet<Role> Roles ==>Set<Role>();

        public readonly  




    }
}
