﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFModels.Models
{
    public partial class ProjectTag
    {
        public ProjectTag()
        {
            Coupons = new HashSet<Coupon>();
            Discounts = new HashSet<Discount>();
        }

        [Key]
        public int ProjectTagId { get; set; }
        [Required]
        [StringLength(30)]
        public string ProjectTagName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreateAt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedAt { get; set; }
        [Required]
        public bool? Status { get; set; }

        [InverseProperty("fk_RequiredProjectTag")]
        public virtual ICollection<Coupon> Coupons { get; set; }
        [InverseProperty("fk_ProjectTag")]
        public virtual ICollection<Discount> Discounts { get; set; }
    }
}