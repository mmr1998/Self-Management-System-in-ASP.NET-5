using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SelfManagement.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Borrower")]
        [Required]
        public string Borrower { get; set; }
        [DisplayName("Lender")]
        [Required]
        public string Lender { get; set; }
        [DisplayName("Item Name")]
        [Required]
        public string ItemName { get; set; }

    }
}
