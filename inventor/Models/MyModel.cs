using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace inventor.Models
{
    public class inventor  // Changed class name from inventor to Inventor. C# naming conventions
    {
        [Key]
        public int id { get; set; }
        public string fio { get; set; }
        public string nomer { get; set; } // лучше использовать string
        public string tip { get; set; }
    }
}
