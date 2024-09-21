using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace API_Post_Eventos_Real.Models
{
    public class Uploads
    {
        [Key]
        public int id { get; set; }
        public int id_de_cuenta { get; set; }
        public DateTime fecha_pub { get; set; }
        public int n_upvotes { get; set; }
        [MaxLength(11)]
        public string tipo { get; set; }
        public bool activo { get; set; }
    }
}