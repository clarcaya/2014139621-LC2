using _2014139621_ENT;
using _2014139621_ENT.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139621_PER.EntitiesConfigurations.Repositories
{
    public class ServicioRepository : Repository<Servicio>, IServicioRepository
    {
        private readonly TransporteDbContext _Context;

        public ServicioRepository(TransporteDbContext context)
        {
            _Context = context;
        }

        private ServicioRepository()
        {

        }

        public IEnumerable<Servicio> GetServicioWithTranspEncom(string transp, string enc)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Servicio> GetServicioWithTranspEncom(int transp, int enc)
        {
            throw new NotImplementedException();
        }
    }
}
