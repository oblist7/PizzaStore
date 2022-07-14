﻿using Microsoft.EntityFrameworkCore;
using PizzaStore.Models;

namespace PizzaStore
{
    class PizzaDb : DbContext
    {
        public PizzaDb(DbContextOptions options) : base(options) { }
        public DbSet<Pizza> Pizzas { get; set; }
    }
}
