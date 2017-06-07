using _2014139621_ENT;
using _2014139621_ENT.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139621_PER.EntitiesConfigurations.Repositories
{
    public class EncomiendaRepository : Repository<Encomienda>, IEncomiendaRepository
    {
        private readonly TransporteDbContext _Context;

        public EncomiendaRepository(TransporteDbContext context)
        {
            _Context = context;
        }

        private EncomiendaRepository()
        {

        }

        public IEnumerable<Encomienda> GetEncomiendaByBus(int cod, string placa)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Encomienda> GetEncomiendaByBus(int cod, int placa)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Encomienda> GetEncomiendaByLugarViaje(LugarViaje lugarviaje)
        {
            throw new NotImplementedException();
        }
    }
}
