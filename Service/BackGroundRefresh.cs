using System;
using System.Threading;
using System.Threading.Tasks;
using Exchange.Service;
using Exchange.Service.IServiceInterface;
using Microsoft.Extensions.Hosting;

namespace RateApi.Service
{
    public class BackGroundRefresh : IHostedService, IDisposable
    {
        private System.Threading.Timer? _timer;
        private readonly SampleData _date;
        private readonly IRateService _showRateService;

        public BackGroundRefresh(SampleData sample, IRateService showRateService)
        {
            _date = sample;
            _showRateService = showRateService;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new System.Threading.Timer(AddToCache, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));
            return Task.CompletedTask;
        }

        private void AddToCache(object? state)
        {
            _showRateService.ShowRates();
            _date.Data.Add($"The new rate has been refresh recently {DateTime.Now.ToLongTimeString()}");
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
