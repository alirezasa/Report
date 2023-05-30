using Microsoft.EntityFrameworkCore;
using WebApi.Context;

namespace WebApi

{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
        }
        public IConfiguration Configuration { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<ReportContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ReportConnStr")));
        }
        
    }
  

   
}
