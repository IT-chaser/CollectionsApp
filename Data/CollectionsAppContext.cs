using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CollectionsApp.Models;

    public class CollectionsAppContext : DbContext
    {
        public CollectionsAppContext (DbContextOptions<CollectionsAppContext> options)
            : base(options)
        {
        }

        public DbSet<CollectionsApp.Models.Collection>? Collection { get; set; }

        public DbSet<CollectionsApp.Models.Item>? Item { get; set; }
    }
