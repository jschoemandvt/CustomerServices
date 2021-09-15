using System;

namespace CustomerServices.CustomerApi.Models
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string FullName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}