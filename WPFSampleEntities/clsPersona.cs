using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSampleEntities
{
    public class clsPersona
    {
        //Atributos
        public int IDPersona { get; set; }
        [Required]
        [Display (Name = "NOMBRE")]
        public String Nombre { get; set; }
        [Required]
        [Display(Name = "APELLIDOS")]
        public String Apellidos { get; set; }
        [Required]
        [Display(Name = "FECHA DE NACIMIENTO")]
        public DateTime FechaNac { get; set; }
        [Required]
        [Display(Name = "DIRECCIÓN")]
        public String Direccion { get; set; }
        [Required]
        [Display(Name = "TELÉFONO")]
        public String Telefono { get; set; }

        //Constructores
        public clsPersona()
        {
            Id = 1;
            Nombre = "";
            Apellidos = "";
            FechaNac = new DateTime();
            Direccion = "";
            Telefono = "";
        }

        public clsPersona(int id, String nombre, String apellidos, DateTime fechaNac, String direccion, String telefono)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            FechaNac = fechaNac;
            Direccion = direccion;
            Telefono = telefono;
        }
    }
}
