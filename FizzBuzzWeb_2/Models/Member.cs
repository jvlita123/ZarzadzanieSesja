using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FizzBuzzWeb_2.Models
{
    public class Member :ValidationAttribute
    {
        [Display(Name = "Rok urodzenia")]

        [Required(ErrorMessage ="uzupełnij dane"), Range(1899, 2022, ErrorMessage = "Oczekiwana wartość {0} z zakresu {1} i {2}.")]
        public int? Year { get; set; }

        [Display(Name = "Imie")]

        [Required(ErrorMessage = "uzupełnij dane"), MaxLength(100, ErrorMessage = "maksymalna długość imienia = 100")]

        public string? Name { get; set; }

        public string IsLeap(object? number)
        {
            
            if ((int)number % 100 != 0 && (int)number % 4 == 0 || (int)number % 400 == 0)
            {
                return "rok przestępny";
            }
            return "rok nie przestępny";
        }
        
        public override bool IsValid(object? value)
        {
            string array1 = Convert.ToString(value);

            if (array1[^1] != 'a')
            {
                ErrorMessage = "urodził się w ";
                return true;
            }

            ErrorMessage = "urodziła się w ";
            return true;
        }



    }


}