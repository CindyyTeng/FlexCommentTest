﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EFModels.Models
{
    public partial class Speaker
    {
        public Speaker()
        {
            Activities = new HashSet<Activity>();
            OneToOneReservations = new HashSet<OneToOneReservation>();
        }

        public int SpeakerId { get; set; }
        public string SpeakerName { get; set; }
        public string SpeakerPhone { get; set; }
        public int fk_SpeakerFieldId { get; set; }
        public string SpeakerImg { get; set; }
        public int? fk_SpeakerBranchId { get; set; }
        public string SpeakerDescription { get; set; }
        public bool SpeakerVisible { get; set; }

        public virtual Branch fk_SpeakerBranch { get; set; }
        public virtual SpeakerField fk_SpeakerField { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<OneToOneReservation> OneToOneReservations { get; set; }
    }
}