﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table(nameof(Producer), Schema = "dbo")]
    public class Producer   
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? Dob { get; set; }

        [StringLength(4000), DataType(DataType.MultilineText)]
        public string? Bio   { get; set; }
    }
}
