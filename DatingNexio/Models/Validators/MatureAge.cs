using System;
using System.ComponentModel.DataAnnotations;


namespace DatingNexio.Models.Validators
{
    public sealed class MatureAgeAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (null == value)
                return false;
            DateTime birthDate = (DateTime)value;
            var age = DateTime.Now.Year - birthDate.Year;
            if (birthDate.AddYears(age) > DateTime.Now)
                age--;
            return age >= 18;
        }
    }
}