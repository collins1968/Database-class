using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_class.Models
{
    //[Table("users", Schema = "Jitu")]
    public class UsersDTO
    {
        [Key]
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public string email { get; set; }
    }

    public class UsersDTO2
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public string email { get; set; }
    }
}
