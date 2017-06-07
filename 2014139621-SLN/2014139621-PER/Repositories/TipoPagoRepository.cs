﻿using _2014139621_ENT;
using _2014139621_ENT.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139621_PER.EntitiesConfigurations.Repositories
{
    public class TipoPagoRepository : Repository<TipoPago>, ITipoPagoRepository
    {
        private readonly TransporteDbContext _Context;

        public TipoPagoRepository(TransporteDbContext context)
        {
            _Context = context;
        }

        private TipoPagoRepository()
        {

        }

        public IEnumerable<TipoPago> GetTipoPagoByVenta(int venta)
        {
            throw new NotImplementedException();
        }
    }
}
