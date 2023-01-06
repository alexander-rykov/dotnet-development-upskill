using System.ComponentModel.DataAnnotations;

namespace ReflectionInDotNet.Demo.Attributes
{
    internal class Employee
    {
        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        //[Positive]
        [Range(0, int.MaxValue)]
        public int Age { get; set; }
    }
}
