﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Auth1.Models {
  public class UserContext : DbContext {
    public DbSet<User> Users { get; set; }
    public UserContext(DbContextOptions<UserContext> options)
        : base(options) {
      Database.EnsureCreated();
    }
  }
}
