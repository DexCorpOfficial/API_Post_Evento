using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_Post_Eventos_Real.Models
{
    public class Comentario
    {
       [Key]
        public int id_de_uploads { get; set; }
        [ForeignKey("id_de_uploads")]
        public Uploads Upload { get; set; }
        public int id_de_post { get; set; }
        [ForeignKey("id_de_post")]
        public Post Post { get; set; }
        [MaxLength(250)]
        public string contenido { get; set; }
    }
}
