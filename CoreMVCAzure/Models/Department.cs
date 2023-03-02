using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCAzure.Models
{
    [Table("Department")]
    public class Department
    {
        [Key]
        public int DeptNo { get; set; }
        public string DName { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Employe> Employes { get; set; }
    }
}
