﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFModels.Models
{
    [Index("LevelName", Name = "UQ__StaffPer__9EF3BE7B6829F02D", IsUnique = true)]
    public partial class StaffPermission
    {
        public StaffPermission()
        {
            Staff = new HashSet<Staff>();
        }

        [Key]
        public int PermissionsId { get; set; }
        [StringLength(30)]
        public string LevelName { get; set; }

        [InverseProperty("fk_Permissions")]
        public virtual ICollection<Staff> Staff { get; set; }
    }
}