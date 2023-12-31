﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFModels.Models
{
    public partial class ShoesColorCategory
    {
        public ShoesColorCategory()
        {
            CustomizedShoesPos = new HashSet<CustomizedShoesPo>();
            ShoesGroups = new HashSet<ShoesGroup>();
        }

        [Key]
        public int ShoesColorId { get; set; }
        [Required]
        [StringLength(50)]
        public string ColorName { get; set; }
        [StringLength(100)]
        public string ColorCode { get; set; }

        [InverseProperty("fk_ShoesColor")]
        public virtual ICollection<CustomizedShoesPo> CustomizedShoesPos { get; set; }
        [InverseProperty("fk_ShoesColor")]
        public virtual ICollection<ShoesGroup> ShoesGroups { get; set; }
    }
}