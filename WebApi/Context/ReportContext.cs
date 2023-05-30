namespace WebApi.Context
{
    using Microsoft.EntityFrameworkCore;
    using WebApi.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.ComponentModel.DataAnnotations;

    public class ReportContext : DbContext
    {

       

        public ReportContext(DbContextOptions<ReportContext> context) : base(context)
            {

            }

         public DbSet<Report> Reports { get; set; }
        public DbSet<TimeSheet> TimeSheets { get; set; }
            public DbSet<Result> Results { get; set; }
       


    }
}