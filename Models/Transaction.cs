﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wallet_Example.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "please select a category.")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "amount should be greater than 0.")]
        public string Amount{ get; set; }

        [Column(TypeName = "nvarchar(80)")]
        public string? Note { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        [NotMapped]
        public string? CategoryTitleWithIcon
        {
            get{ return Category == null ? "" : Category.Icon + " " + Category.Title;}
        }

        [NotMapped]
        public string? FormattedAmount
        {
            get{return ((Category == null || Category.Type == "Expense") ? "- " :
                    "+ ") + Amount.ToString();}
        }
    }
}
