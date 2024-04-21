
using Exchange.Data;
using Exchange.Repository;
using Exchange.Repository.IRepositoryInterface;
using Exchange.Service;
using Exchange.Service.IServiceInterface;
using Microsoft.EntityFrameworkCore;
using RateApi.Service;

namespace RateApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);      

            builder.Services.AddDbContext<ExchangeDBContext>(options =>
                 options.UseNpgsql(builder.Configuration.GetConnectionString("ExDatabase")));

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddHostedService<BackGroundRefreshService>();
            builder.Services.AddScoped<IExchangeProvaidorRepository, ExchangeProvaidorRepository>();
            builder.Services.AddScoped<IRateRepository, RateRepository>();
            builder.Services.AddScoped<IExchangeProvaidorService, ExchangeProvaidorService>();
            builder.Services.AddScoped<IRateService, RateService>();

            var app = builder.Build();
         
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();
        
            app.MapControllers();

            app.Run();
        }
    }
}
