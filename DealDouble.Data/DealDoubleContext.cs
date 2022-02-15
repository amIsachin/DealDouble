﻿using DealDouble.Entities;
using System;
using System.Data.Entity;

namespace DealDouble.Data
{
    public class DealDoubleContext : DbContext, IDisposable
    {
        public DealDoubleContext() : base("name=DealDoubleConnectionString")
        {
        }

        public DbSet<Auction> Auctions { get; set; }
    }
}
