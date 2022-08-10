using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.context
{
    internal class BookStoreContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public BookStoreContext(DbContextOptions<BookStoreContext> option) : base(option)
        {
        }

    }
}
