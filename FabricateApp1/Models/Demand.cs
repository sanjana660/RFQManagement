﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FabricateApp1.Models
{
    public class Demand
    {
        [Key]
        public int DemandId { get; set; }

        public int DemandCount { get; set; }
        [ForeignKey("Part")]
        public int PartId { get; set; }
        public DateTime DemandRaisedDate { get; set; }
    }
}
