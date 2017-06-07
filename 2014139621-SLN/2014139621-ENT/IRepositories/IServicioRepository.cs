using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139621_ENT.Entities.IRepositories
{
    public interface IServicioRepository : IRepository<Servicio>
    {
        IEnumerable<Servicio> GetServicioWithTranspEncom(int transp, int enc);
    }
}
