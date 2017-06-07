using _2014139621_ENT;
using _2014139621_ENT.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139621_PER.EntitiesConfigurations.Repositories
{
    public class EmpleadoRepository : Repository<Empleado>, IEmpleadoRepository
    {
        private readonly TransporteDbContext _Context;

        public EmpleadoRepository(TransporteDbContext context)
        {
            _Context = context;
        }

        private EmpleadoRepository()
        {

        }

        public IEnumerable<Empleado> GetEmpleadoWithTripulacion(int trip)
        {
            throw new NotImplementedException();
        }
    }
}
