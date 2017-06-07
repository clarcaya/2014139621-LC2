using _2014139621_ENT;
using _2014139621_ENT.Entities.IRepositories;
using _2014139621_PER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139621_PER.EntitiesConfigurations.Repositories
{
    public class AdministrativoRepository : Repository<Administrativo>, IAdministrativoRepository
    {
        private readonly TransporteDbContext _Context;

        private AdministrativoRepository()
        {
               
        }

        public AdministrativoRepository(TransporteDbContext context)
        {
            _Context = context;
        }

        public IEnumerable<Administrativo> GetVentasByAdministrativo(Venta venta)
        {
            throw new NotImplementedException();
        }
    }
}
