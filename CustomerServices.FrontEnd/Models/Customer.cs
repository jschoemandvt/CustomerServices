using System;

namespace CustomerServices.FrontEnd.Models
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string FullName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}