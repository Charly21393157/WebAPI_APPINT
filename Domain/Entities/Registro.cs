using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Registro
    {
        [Key]
        public int PkRegistro { get; set; }
        public string Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Cantidad { get; set; }

        [ForeignKey("Tipos")]
        public int FkTipo { get; set; }
        public Tipo Tipos { get; set; }
    }
}
