namespace WebApi.Models
{

    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
   
    [Table("Result")]
    public class Result
    {

        public int ID { get; set; }

        public int? UserID { get; set; }

        public int? Year { get; set; }

        public string? Month { get; set; }

        public int? WorkingDays { get; set; }
    }
}
