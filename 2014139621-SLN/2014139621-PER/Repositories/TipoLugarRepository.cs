using _2014139621_ENT;
using _2014139621_ENT.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139621_PER.EntitiesConfigurations.Repositories
{
    public class TipoLugarRepository : Repository<TipoLugar>, ITipoLugarRepository
    {
        private readonly TransporteDbContext _Context;

        public TipoLugarRepository(TransporteDbContext context)
        {
            _Context = context;
        }

        private TipoLugarRepository()
        {
                
        }

        public IEnumerable<TipoLugar> GetTipoLugarWithLugarviaje(int lugarviaje)
        {
            throw new NotImplementedException();
        }
    }
}
