using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DXSample {
    public class ViewModel {
        public Contact Contact { get; set; }
        public ViewModel() {
            Contact = new Contact() {
                FirstName = "Carolyn",
                LastName = "Baker",
                Email = "carolyn.baker@example.com",
                Phone = "(555)349-3010",
                Address = "1198 Theresa Cir",
                City = "Whitinsville",
                State = "MA",
                Zip = "01582"
            };
        }
    }
    public class Contact {
        [MaxLength(25, ErrorMessage = "Value is too long")]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string CreditCardNumber { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        [CustomValidation(typeof(ContactValidator), "ValidateString")]
        public string State { get; set; }

        public string Zip { get; set; }
    }
    public class ContactValidator {
        public static ValidationResult ValidateString(object value) {
            if (value == null || value.ToString().Length > 25)
                return new ValidationResult("Value is too long");
            return ValidationResult.Success;
        }
    }
}