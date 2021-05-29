using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SyamDatingAppV_1.Entities
{
    [Table("AppUser")]
    public class AppUser
    {
        [Required]

        public int Id { get; set; }
        public string  UserName { get; set; }
        public string AGE { get; set; }
    }
}
