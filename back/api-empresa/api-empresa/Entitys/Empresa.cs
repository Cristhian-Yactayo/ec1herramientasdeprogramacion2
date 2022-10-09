using System.ComponentModel.DataAnnotations;

namespace api_empresa.Entitys
{
    public class Empresa
    {
        //definimos la clave primaria
        [Key]
        public int codigo { get; set; }

        //definimos valores no nulos
        [Required]
        //definimos el tamaño del campo
        [StringLength(
            maximumLength:100,
            ErrorMessage ="Se tiene que ingresar un nombre"
            )]
        public string nombre { get; set; }
        
        //definimos valores no nulos
        [Required]
        //definimos el tamaño del campo
        [StringLength(
            maximumLength: 8,
            ErrorMessage = "Se tiene que ingresar un dni"
            )]
        public string dni { get; set; }

        //definimos valores no nulos
        [Required]
        //definimos el tamaño del campo
        [StringLength(
            maximumLength: 100,
            ErrorMessage = "Se tiene que ingresar un correo"
            )]
        public string correo { get; set; }



    }
}
