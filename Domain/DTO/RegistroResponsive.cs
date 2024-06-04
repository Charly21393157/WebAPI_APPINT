using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class RegistroResponsive
    {
        public string Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Cantidad { get; set; }
        public int FkTipo { get; set; }
    }
}
