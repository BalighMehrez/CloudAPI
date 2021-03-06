﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Dataocean.Venus.Configuration;
using Dataocean.Venus.Web;

namespace Dataocean.Venus.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class VenusDbContextFactory : IDesignTimeDbContextFactory<VenusDbContext>
    {
        public VenusDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<VenusDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder(), addUserSecrets: true);

            VenusDbContextConfigurer.Configure(builder, configuration.GetConnectionString(VenusConsts.ConnectionStringName));

            return new VenusDbContext(builder.Options);
        }
    }
}
