﻿using _2014139621_ENT;
using _2014139621_ENT.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139621_PER.EntitiesConfigurations.Repositories
{
    public class BusRepository : Repository<Bus>, IBusRepository
    {
        private readonly TransporteDbContext _Context;

        public BusRepository(TransporteDbContext context)
        {
            _Context = context;
        }

        private BusRepository()
        {

        }

        public IEnumerable<Bus> GetTripulacionByBus(Tripulacion tripulacion)
        {
            throw new NotImplementedException();
        }
    }
}