namespace WebApi.Models
    {
        using System.ComponentModel.DataAnnotations;
        using System.ComponentModel.DataAnnotations.Schema;

        [Table("TimeSheet")]
        public class TimeSheet
        {


        public int ID { get; set; }

        public int? UserID { get; set; }

        public int? Year { get; set; }
       
        public string? Month { get; set; }

        public int? WorkingDays { get; set; }
    }
}



