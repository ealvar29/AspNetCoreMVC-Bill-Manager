﻿using System.ComponentModel.DataAnnotations;

namespace BillManager.Models
{
    public class Bill
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Range(1,int.MaxValue)]
        public double Price { get; set; }

        public string Image { get; set; }
    }
}