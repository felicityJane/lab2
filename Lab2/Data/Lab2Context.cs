using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Lab2.Models
{
    public class Lab2Context : IdentityDbContext

    {
        public Lab2Context (DbContextOptions<Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Lab2.Models.Book> Book { get; set; }

        public DbSet<Lab2.Models.Author> Author { get; set; }
    }
}
