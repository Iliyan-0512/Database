using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitiFrameworkWithMysql
{
    public partial class Hobby
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string HobbyName  { get; set; } 
    }

}
