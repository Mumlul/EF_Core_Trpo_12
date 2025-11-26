using EF_Core.Models.Service;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EF_Core.Rules.Validations
{
    public class Email:ValidationRule
    {

        public UserService UserService { get; set; } = new();
        
        public override ValidationResult Validate(object? value, CultureInfo cultureInfo)
        {
            var input =(value??"").ToString().Trim();

            if (!input.Contains('@')) return new ValidationResult(false, "В поле должен быть символ @");

            if (!Unique_email(input)) return new ValidationResult(false, "Email должен быть уникальным");

            return ValidationResult.ValidResult;
        }

        public bool Unique_email(string email)
        {
            int count = 0;
            foreach (var user in UserService.Users) 
            {
                if (user.Email == email) count++;
                if (count == 2) return false;
            }

            return true;
        }
    }
}
