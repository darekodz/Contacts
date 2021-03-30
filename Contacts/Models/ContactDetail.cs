using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts.Models
{
    public class ContactDetail
    {
        [Key]
        public int ContactDetailId { get; set; }
        
        [Column (TypeName ="nvarchar(100)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Surname { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string MobilePhone { get; set; }
    }
}
