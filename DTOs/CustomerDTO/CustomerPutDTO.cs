using System.ComponentModel.DataAnnotations;

namespace KHanERP.DTOs.CustomerDTO
{
    public class CustomerPutDTO
    {
        [Required]
        public required string FullName { get; set; } // Full name of the customer

        [EmailAddress]
        public string? Email { get; set; } // Email of the customer

        [Phone]
        public string? PhoneNumber { get; set; } // Phone number of the customer

        [StringLength(100)]
        public string? Address { get; set; } // Address of the customer

        [StringLength(100)]
        public string? Notes { get; set; } // Notes about the customer
        public double Debt { get; set; } = 0; // Debt amount of the customer
    }
}
