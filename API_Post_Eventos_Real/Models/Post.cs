using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace API_Post_Eventos_Real.Models
{
    public class Post
    {
        [Key]
        public int id_de_uploads { get; set; }
        [ForeignKey("id_de_uploads")]
        public Uploads Upload { get; set; }
        [MaxLength(300)]
        public string descripcion { get; set; }
        [Required]
        public byte[] media { get; set; }
        public string tipo { get; set; }
        public int id_de_banda { get; set; }

    }
}
