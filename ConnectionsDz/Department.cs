using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionsDz
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Employer")]
        public int EmployerId { get; set; }
        public Employer Employer{ get; set; }
    }
}
