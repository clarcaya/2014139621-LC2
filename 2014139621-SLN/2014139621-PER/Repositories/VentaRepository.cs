﻿using _2014139621_ENT;
using _2014139621_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139621_PER.Repositories
{
    public class VentaRepository : Repository<Venta>, IVentaRepository
    {
        public VentaRepository(DbContext context) : base(context)
        {
        }

    }
}
