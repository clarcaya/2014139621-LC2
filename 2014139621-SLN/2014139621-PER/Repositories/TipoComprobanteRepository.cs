using _2014139621_ENT;
using _2014139621_ENT.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139621_PER.EntitiesConfigurations.Repositories
{
    public class TipoComprobanteRepository : Repository<TipoComprobante>, ITipoComprobanteRepository
    {
        private readonly TransporteDbContext _Context;

        public TipoComprobanteRepository(TransporteDbContext context)
        {
            _Context = context;
        }

        private TipoComprobanteRepository()
        {

        }

        public IEnumerable<TipoComprobante> GetTipoComprobanteByVenta(Venta venta)
        {
            throw new NotImplementedException();
        }
    }
}
