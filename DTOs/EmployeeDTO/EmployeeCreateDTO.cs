using KHanERP.Models;
using System.ComponentModel.DataAnnotations;

namespace KHanERP.DTOs.EmployeeDTO
{
    public class EmployeeCreateDTO
    {
        public string? UserName { get; set; }
        public string? Password { get; set; } // Password should be hashed and salted

        public string? RoleID { get; set; } // Foreign key to Role

        [Required]
        public required string FullName { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [Phone]
        public string? PhoneNumber { get; set; }
        public string? Position { get; set; } // like "Manager", "Developer", etc.

        [Range(0, double.MaxValue, ErrorMessage = "Salary must be a positive number.")]
        public decimal? Salary { get; set; }

        [DataType(DataType.Date)]
        public DateTime? HireDate { get; set; }
        public int? DepartmentID { get; set; } // Foreign key to Department
    }
}
