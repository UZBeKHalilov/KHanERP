namespace KHanERP.DTOs.CustomerDTO
{
    public class CustomerGetDTO
    {
        public int ID { get; set; }
        public required string FullName { get; set; } // Full name of the customer
        public string? Email { get; set; } // Email of the customer
        public string? PhoneNumber { get; set; } // Phone number of the customer
        public string? Address { get; set; } // Address of the customer
        public DateTime CreatedAT { get; set; } // Date when the customer was created 
        public string? Notes { get; set; } // Notes about the customer
        public double Debt { get; set; } = 0; // Debt amount of the customer
    }
}
