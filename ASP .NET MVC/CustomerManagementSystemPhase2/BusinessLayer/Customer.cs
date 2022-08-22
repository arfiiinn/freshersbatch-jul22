using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
       
        [StringLength(50, ErrorMessage = "Name can only be 50 characters long.")]
        [Required]
        public string CustomerName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "City Name can only be 50 characters long.")]
        public string City { get; set; }
        [Required]
        [Range(13, 100, ErrorMessage = "Age should be between 13 and 100.")]
        public int Age { get; set; }
        [Required]
        [Range(1000000000, 9999999999)]
        public double Phone { get; set; }
        [Required]
        public int Pincode { get; set; }
    }
}