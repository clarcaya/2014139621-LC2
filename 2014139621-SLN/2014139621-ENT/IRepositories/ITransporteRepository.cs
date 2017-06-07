using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139621_ENT.Entities.IRepositories
{
    public interface ITransporteRepository : IRepository<Transporte>
    {
        IEnumerable<Transporte> GetTransporteByCliente(Cliente cliente);
        IEnumerable<Transporte> GetTransporteByTipoViaje(TipoViaje tipoviaje);
        IEnumerable<Transporte> GetTransporteByBys(Bus bus);
        IEnumerable<Transporte> GetTransporteByLugarViaje(LugarViaje lugarviaje);
        IEnumerable<Transporte> GetTransporteByServicio(Servicio servicio);
    }
}
