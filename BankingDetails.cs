using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace KFP.DATA
{
    public class BankingDetails
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int PaymentNo { get; set; }

        [DisplayName("Bank Name")]
        [Required]
        public string BankName { get; set; }

        [DisplayName("Account Type")]
        [Required]
        public string AccountType { get; set; }

        [DataType(DataType.CreditCard)]
        [DisplayName("Account Number")]
        [Required]
        public string AccountNumber { get; set; }

        [DisplayName("Branch Code")]
        [Required]
        public string BranchCode { get; set; }

        [DisplayName("Debit Order Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DebitOrder_date { get; set; }

        [DisplayName("Payment Method")]
        [Required]
        public string PaymentMethod { get; set; }

        [DisplayName("CVV Number")]
        [Required]
        public int CVV_Number { get; set; }





    }
}

