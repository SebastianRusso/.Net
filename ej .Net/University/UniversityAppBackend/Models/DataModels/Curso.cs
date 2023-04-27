

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UniversityAppBackend.Models.DataModels
{
    public class Curso: BaseEntity
    {
        [Required, StringLength(150)]
        public string NameLastName { get; set; } = string.Empty;

        [Required, StringLength(2000)]
        public string DescripcionCorta { get; set; } = string.Empty;

        [Required, StringLength(5000)]
        public string DescripcionLarga { get; set; } = string.Empty;

        [Required, StringLength(1500)]
        public string PublicoObjetivo { get; set; } = string.Empty;

        [Required, StringLength(1500)]
        public string Objetivos { get; set; } = string.Empty;

        [Required, StringLength(1000)]
        public string Requisitos { get; set; } = string.Empty;

        [Required, StringLength(280)]
        public string Nivel { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;


    
    }
}


/* Asegúrate de crear correctamente el diagrama del modelo de EntityFramework

Crea una clase llamada Curso que debe tener: Nombre(máximo) Descripción Corta(máximo 280 caracteres)

Descripción larga, Público Objetivo, Objetivos, Requisitos

Nivel(solo puede ser Básico, Intermedio o Avanzado para ello usa un enumerado  */