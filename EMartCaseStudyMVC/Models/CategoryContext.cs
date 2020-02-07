﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMartCaseStudyMVC.Models
{
    public class CategoryContext:DbContext
    {
        public CategoryContext(DbContextOptions<CategoryContext>options):base(options)
            { }
        public DbSet<Category> Category { get; set; }
    }
}
