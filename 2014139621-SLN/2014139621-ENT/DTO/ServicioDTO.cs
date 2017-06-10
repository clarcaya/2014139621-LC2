using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2014139621_API.DTO
{
    public abstract class ServicioDTO
    {
        public int ServicioId { get; set; }
        public string NombreServicio { get; set; }
        public decimal Tarifa { get; set; }
    }
}