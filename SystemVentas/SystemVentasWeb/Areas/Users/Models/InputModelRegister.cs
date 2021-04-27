using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SystemVentasWeb.Areas.Users.Models
{
    public class InputModelRegister
    {
      [Required(ErrorMessage = "El campo nombre es obligatorio")]
      public string Name { get; set; }

      [Required(ErrorMessage = "El campo apellido es obligatorio")]

      public string LastName { get; set; }

      [Required(ErrorMessage = "El campo nid es obligatorio")]
       public string NID { get; set; }

      [Required(ErrorMessage = "El campo telefono es obligatorio")]
      [DataType(DataType.PhoneNumber)]
      [RegularExpression(@"^\(?([0-9]{2})\)?[-. ]?([0-9]{2})[-. ]?([0-9]{5})$",ErrorMessage ="<font color='red'>El formato telefono ingresado no es valido.")]

        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "El campo correo electronico es obligatorio")]
        [EmailAddress(ErrorMessage ="El campo correo electronico no es una direccion de coreo electronico valido")]
        public string Email { get; set; }

        [Display(Name ="Contraseña")]
        [Required(ErrorMessage = "El campo contraseña es obligatorio")]
        [StringLength(100,ErrorMessage = "El numero de caracteres de {0} de ser al menos {2}.", MinimumLength =6)]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; }

    }
}
