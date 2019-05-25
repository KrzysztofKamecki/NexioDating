using DatingNexio.Models.Validators;
using System;
using System.ComponentModel.DataAnnotations;

namespace DatingNexio.Models
{
    public class Person
    {
        [Display(Name="Imię:")]
        [Required(ErrorMessage ="Proszę podać imię")]
        [MinLength(3)]
        public string Name { get; set; }

        [Display(Name = "Wzrost w metrach:")]
        [Required(ErrorMessage = "Proszę podać wzrost")]
        public double Height { get; set; } // in metters

        [Display(Name = "Data urodzenia:")]
        [Required(ErrorMessage = "Proszę podać datę urodzenia")]
        [MatureAge(ErrorMessage = "Data urodzenia powinna wskazywać na wiek >=18 lat")]
        public DateTime BirthDate { get; set;}

        [Display(Name = "Kolor oczu:")]
        [Required(ErrorMessage = "Proszę podać kolor oczu")]
        public EyeColourEnum EyeColour { get; set; }
    }
}