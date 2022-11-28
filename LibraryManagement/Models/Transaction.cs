﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }
        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Account Number")]
        [Required(ErrorMessage = "This Field Is Required")]
        [MaxLength(12, ErrorMessage = "Max 12 Character Is Required")]
        public string AccountNumber { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Beneficiary Name")]
        [Required(ErrorMessage = "This Field Is Required")]
        public string BeneficiaryName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Bank Name")]
        [Required(ErrorMessage = "This Field Is Required")]
        public string BankName { get; set; }
        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("IFSC Code")]
        [Required(ErrorMessage = "This Field Is Required")]
        [MaxLength(11, ErrorMessage = "Max 11 Character Is Required")]
        public string IFSCCode { get; set; }
        [Required(ErrorMessage = "This Field Is Required")]
        public int Amount { get; set; }
        [DisplayFormat(DataFormatString = "{0:MMM-dd-yy}")]
        public DateTime Date { get; set; }

    }
}
