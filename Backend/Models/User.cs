using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        public string Cedula { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Nombre{ get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime FechaNac { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public string Telefono{ get; set; }
        
    }
}
