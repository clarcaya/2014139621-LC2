﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139621_ENT.Entities.IRepositories
{
    public interface ILugarViajeRepository : IRepository<LugarViaje>
    {
        IEnumerable<LugarViaje> GetLugarviajeByTipoLugar(TipoLugar tipolguar);
    }
}