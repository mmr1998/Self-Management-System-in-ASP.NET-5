using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SelfManagement.Models
{
    public class Expense
    {
        [Key]
        public int ExpenseId { get; set; }
        [DisplayName("Expense Item")]
        [Required]
        public string ExpenseItem { get; set; }
        [DisplayName("Expense Amount")]
        [Required]
        [Range(1, int.MaxValue, ErrorMessage ="Amount Must be greater than 0!")]
        public int Amount { get; set; }

        [DisplayName("Expense Type")]
        public int ExTypeId { get; set; }
        [ForeignKey("ExTypeId")]
        public virtual ExpenseType ExpenseType { get; set; }
    }
}
