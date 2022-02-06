using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AgenciaCronos.Models

{
    public class CronosContext : DbContext
    {
        public DbSet<Integrante> Integrantes { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Servico> Servicos { get; set; }


        public CronosContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            //var path = Environment.GetFolderPath(folder);
            //DbPath = System.IO.Path.Join(path, "blogging.db");

        }


        public string DbPath { get; private set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //  => optionsBuilder.UseNpgsql(@"Host=localhost;Username=admin;Port=5432;Password=Senha@1234;Database=agencia_cronos");
        => optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CRONOS");
     }

}
