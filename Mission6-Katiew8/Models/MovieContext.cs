﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_Katiew8.Models
{
    public class MovieContext : DbContext
    {
        //Constructor
        public MovieContext(DbContextOptions<MovieContext>options): base (options)
        {
            //leave blank for now
        }

        public DbSet<MovieResponse> responses { get; set; }
    }
}
