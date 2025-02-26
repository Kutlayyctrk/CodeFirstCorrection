using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstCorrection.Entities
{
    class Job
    {
        [Key]
        public int JobID { get; set; }
        public string JobName { get; set; }
    }
}
