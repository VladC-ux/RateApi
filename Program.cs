
using Exchange.Service;
using RateApi.Service;

namespace RateApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddSingleton<SampleData>();
            builder.Services.AddSingleton<RateService>();   
            builder.Services.AddHostedService<BackGroundRefresh>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();
            
            app.MapGet("/masseges",(SampleData data)=>data.Data.Order());
         

            app.MapGet("/messages", async (RateService rateService) =>
            {
                var rates = rateService.ShowRates();
              
                return Results.Json(rates);
            });


            app.MapControllers();

            app.Run();
        }
    }
}
