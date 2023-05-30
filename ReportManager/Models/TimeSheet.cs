namespace ReportManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public partial class TimeSheet
    {
        [Key]
        public int ID { get; set; }

        public int? UserID { get; set; }

        public int? Year { get; set; }

        [StringLength(255)]
        public string Month { get; set; }

        public int? WorkingDays { get; set; }
    }
}
