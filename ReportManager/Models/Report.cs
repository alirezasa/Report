namespace ReportManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    
    public partial class Report
    {
        [Key]
        public int ID { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [Column(TypeName = "text")]
        public string Query { get; set; }

        public int? Status { get; set; }
    }
}
