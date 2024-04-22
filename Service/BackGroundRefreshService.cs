using System;
using System.Threading;
using System.Threading.Tasks;
using Exchange.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using RateApi.Contracts.IService;

namespace RateApi.Service
{
    public class BackGroundRefreshService : IHostedService, IDisposable
    {
        private System.Threading.Timer? _timer;
      
        private  IRateService _showRateService;
        private  IServiceScopeFactory _scopeFactory;
        public BackGroundRefreshService(IServiceScopeFactory scopeFactory)
        {         
            _scopeFactory = scopeFactory;
        }
        public Task StartAsync(CancellationToken cancellationToken)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
              _showRateService = scope.ServiceProvider.GetRequiredService<IRateService>();
                
            }
            _timer = new System.Threading.Timer(AddToCache, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));
            return Task.CompletedTask;
        }
        private void AddToCache(object? state)
        {
            _showRateService.ShowRates();
           
        }
        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }
        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
