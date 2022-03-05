using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace B315_01_MVC6_SignUp_ClientSide_ServerSide.Attributes
{
    public class ValidateCheckBox : ValidationAttribute, IClientModelValidator
    {
        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val-checkbox", ErrorMessage);
        }

        public override bool IsValid(object? value)
        {
            return (bool)value;
        }
    }
}
