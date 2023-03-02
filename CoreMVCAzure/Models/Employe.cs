using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace CoreMVCAzure.Models
{
    [Table("Employe")]
    public class Employe
    { 
        [Key]
        public int EmpId { get; set; }
        public string Ename { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }

        [ForeignKey("Department")]
        public int DeptNo { get; set; }

        public virtual Department Department { get; set; }

    }
}
