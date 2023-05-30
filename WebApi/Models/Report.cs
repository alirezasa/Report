namespace WebApi.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Report")]
    public class Report
    {
     

        public int ID { get; set; }

        public string? Title { get; set; }

        public string? Query { get; set; }

        public int? Status { get; set; }
    }
}
