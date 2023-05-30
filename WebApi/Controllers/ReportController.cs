using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System;
using WebApi.Context;
using WebApi.Models;
using Microsoft.Data.SqlClient;
using Azure;
using System.Reflection.Metadata;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly ReportContext _reportContext;

        public ReportController(ReportContext reportContext)
        {
            _reportContext = reportContext;
        }
      

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var reports = await _reportContext.Reports.ToListAsync();
            return Ok(reports);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetReportByIdAsync(int id)
        {
            var report = _reportContext.Reports.FirstOrDefault(r => r.ID == id);
            var query = _reportContext.TimeSheets
                .FromSqlRaw($"{report.Query}")
                .ToList();

            return Ok(query);


        }

        









    }

     

    }

