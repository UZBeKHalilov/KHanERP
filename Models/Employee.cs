namespace KHanERP.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; } // Password should be hashed and salted

        public string? RoleID { get; set; } // Foreign key to Role
        public virtual Role? Role { get; set; } // like "Admin", "User", etc.

        public required string FullName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Position { get; set; } // like "Manager", "Developer", etc.
        public decimal? Salary { get; set; }
        public DateTime HireDate { get; set; } = DateTime.UtcNow; // Date when the employee was hired

        public int? DepartmentID { get; set; } // Foreign key to Department
        public virtual Department? Department { get; set; } // like "HR", "IT", etc.
    }
}
