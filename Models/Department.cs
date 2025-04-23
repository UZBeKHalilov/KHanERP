namespace KHanERP.Models
{
    public class Department
    {
        public int ID { get; set; }
        public required string Name { get; set; } // like "HR", "IT", etc.   
        public string? Description { get; set; } // Description of the department
        public string? Location { get; set; } // Location of the department

        public int? ManagerID { get; set; } // Foreign key to Employee
        public virtual Employee? Manager { get; set; } // Head of the department like "John Doe"

        public decimal? Budget { get; set; } // Budget allocated to the department like "$100,000" 
        public string? ContactNumber { get; set; } // Contact number of the department
        public string? Email { get; set; } // Email of the department
        public string? Website { get; set; } // Website of the department
        public DateTime EstablishedDate { get; set; } = DateTime.UtcNow; // Date when the department was established

        public virtual ICollection<Employee>? Employees { get; set; } = new List<Employee>(); // List of employees in the department

    }
}
