using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthzExample.Data
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }

        [ForeignKey("IdentityUser")]
        public string CreatedUserID { get; set; }
        public IdentityUser User { get; set; }
    }
}