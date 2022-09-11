using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET.Core.AjaxFormValidation.Models
{
    public class Alumno
    {
        [Required(ErrorMessage = "El DNI es obligatorio.")]
        [StringLength(9, ErrorMessage = "El DNI no es válido.")]
        [RegularExpression("^((([A-Za-z])\\d{8})|(\\d{8}([A-Za-z])))$", ErrorMessage = "El DNI no es válido.")]
        [Remote(action: "Register", controller: "Home")]
        public string DNI { get; set; } = null!;

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres.")]
        [Remote(action: "Register", controller: "Home", AdditionalFields = nameof(Apellidos))]
        public string Nombre { get; set; } = null!;

        [Required(ErrorMessage = "Los apellidos son obligatorios.")]
        [StringLength(250, ErrorMessage = "Los apellidos no puede tener más de 250 caracteres.")]
        [Remote(action: "Register", controller: "Home", AdditionalFields = nameof(Nombre))]
        public string Apellidos { get; set; } = null!;

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria.")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de nacimiento")]
        [Remote(action: "Register", controller: "Home")]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Los datos de interes son obligatorios.")]
        [StringLength(1000, ErrorMessage = "Los datos de interés no puede tener más de 1000 caracteres.")]
        [Remote(action: "Register", controller: "Home")]
        public string DatosInteres { get; set; } = null!;

        [Required(ErrorMessage = "La nota media es obligatoria.")]
        [Range(0, 10, ErrorMessage = "La nota media debe ser un número entre 0 y 10 con decimales.")]
        [Remote(action: "Register", controller: "Home")]
        public float NotaMedia { get; set; } = 0;

        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        [Phone(ErrorMessage = "El teléfono no es válido.")]
        [Remote(action: "Register", controller: "Home")]
        public string Telefono { get; set; } = null!;

        [Required(ErrorMessage = "El email es obligatorio.")]
        [EmailAddress(ErrorMessage = "El email no es válido.")]
        [Remote(action: "Register", controller: "Home")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "La url del curso es obligatorio.")]
        [Url(ErrorMessage = "La url del curso no es válida.")]
        [Remote(action: "Register", controller: "Home")]
        public string UrlCurso { get; set; } = null!;
    }
}
