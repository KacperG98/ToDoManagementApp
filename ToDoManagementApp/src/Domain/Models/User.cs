using Domain.Common;
using Domain.Enums;
using Domain.ValueObjects;
using System.Collections.Generic;

namespace Domain.Models
{
    public class User : AuditableEntity
    {
        public PersonName UserName{ get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public AppRole Role { get; set; }

        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
        public ICollection<Ticket> Tasks { get; set; }
    }
}
