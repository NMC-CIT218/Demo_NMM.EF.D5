using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace Demo_NMM.EF.D2.Models
{
    public class IdentityRoleTemp
    {
        [Key]
        public string ID { get; set; }

        [Required]
        public string Name { get; set; }

        public IdentityRoleTemp() { }

        public IdentityRoleTemp(IdentityRoleTemp role)
        {
            this.Name = role.Name;
        }
    }
}