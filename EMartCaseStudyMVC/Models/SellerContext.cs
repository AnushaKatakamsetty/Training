﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMartCaseStudyMVC.Models
{
    public class SellerContext:DbContext
    {

        public SellerContext(DbContextOptions<SellerContext> options) : base(options)
        { }
        public DbSet<Seller> Seller { get; set; }
    }
}
