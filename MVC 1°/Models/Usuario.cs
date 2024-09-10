using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_1_.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    [Required (ErrorMessage = "Este campo es requerido")]
    public string? Email { get; set; }

    [Display (Name = "Contraseña")]
    [DataType (DataType.Password)]
    [Compare ("Clave", ErrorMessage = "Las claves no coinciden")]

    public string? Clave { get; set; }

    [Display(Name = "Contraseña")]
    [NotMapped]
    [DataType(DataType.Password)]
    [Compare("Clave", ErrorMessage = "Las claves no coinciden")]



    public string? ReClave {  get; set; }
    
}
