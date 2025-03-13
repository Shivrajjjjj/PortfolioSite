using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PortfolioSite.Models
{
    public class ContactMessage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}