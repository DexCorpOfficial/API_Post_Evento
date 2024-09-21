using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_Post_Eventos_Real.Models
{
    public class Evento
    {
        [Key]
        public int id_de_uploads { get; set; }
        [ForeignKey("id_de_uploads")]
        public Uploads Upload { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        [MaxLength(300)]
        public string descripcion { get; set; }
        [MaxLength(50)]
        public string nombre { get; set; }
    }
}
