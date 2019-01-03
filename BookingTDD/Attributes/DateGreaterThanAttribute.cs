namespace BookingTDD.Attributes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    internal sealed class DateGreaterThanAttribute : ValidationAttribute, IClientValidatable
    {
        private readonly string OtherPropertyName;

        public DateGreaterThanAttribute(string otherPropertyName, string errorMessage) : base(errorMessage)
        {
            OtherPropertyName = otherPropertyName;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            ValidationResult validationResult = ValidationResult.Success;
            try
            {
                var otherPropertyInfo = validationContext.ObjectType.GetProperty(OtherPropertyName);

                if (otherPropertyInfo.PropertyType.Equals(new DateTime().GetType()))
                {
                    DateTime toValidate = (DateTime)value;
                    DateTime referenceProperty = (DateTime)otherPropertyInfo.GetValue(validationContext.ObjectInstance, null);

                    if (toValidate.CompareTo(referenceProperty) < 1)
                    {
                        validationResult = new ValidationResult(ErrorMessageString);
                    }
                }
                else
                {
                    validationResult = new ValidationResult("An error occurred while validating the property. Origin is not of type DateTime");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return validationResult;
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            string errorMessage = ErrorMessageString;

            // The value we set here are needed by the jQuery adapter
            ModelClientValidationRule dateGreaterThanRule = new ModelClientValidationRule
            {
                ErrorMessage = errorMessage,
                ValidationType = "dategreaterthan"
            };
            //"otherpropertyname" is the name of the jQuery parameter for the adapter, must be LOWERCASE!
            dateGreaterThanRule.ValidationParameters.Add("otherpropertyname", this.OtherPropertyName);

            yield return dateGreaterThanRule;
        }
    }
}