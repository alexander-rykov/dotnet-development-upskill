using System;
using System.ComponentModel.DataAnnotations;

namespace ReflectionInDotNet.Demo.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter | AttributeTargets.Field)]
    internal class PositiveAttribute : ValidationAttribute
    {
        private const string ErrorFormatMessage = "The field {0} must contain positive value";

        public PositiveAttribute()
            : base(ErrorFormatMessage)
        {
        }

        public override bool IsValid(object value)
        {
            return (int)value >= 0;
        }
    }
}
