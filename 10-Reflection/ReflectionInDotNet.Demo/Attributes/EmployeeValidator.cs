using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace ReflectionInDotNet.Demo.Attributes
{
    internal class EmployeeValidator
    {
        private readonly List<string> _errors = new();

        /// <summary>
        /// Gets the validation errors occured during the last validation.
        /// </summary>
        public IEnumerable<string> Errors => _errors;

        /// <summary>
        /// Validates the <paramref name="employee"/>.
        /// </summary>
        public bool ValidateEmployee(Employee employee)
        {
            _errors.Clear();

            var properties = typeof(Employee).GetProperties();
            foreach (var property in properties)
            {
                var propertyValue = property.GetValue(employee);
                var propertyAttributes = property.GetCustomAttributes<ValidationAttribute>(false);
                foreach (var attribute in propertyAttributes)
                {
                    if (!attribute.IsValid(propertyValue))
                    {
                        _errors.Add(attribute.FormatErrorMessage(property.Name));
                    }
                }
            }

            return _errors.Count == 0;
        }
    }
}
