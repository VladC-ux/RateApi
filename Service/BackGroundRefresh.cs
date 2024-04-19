
namespace RateApi.Service
{
    public class BackGroundRefresh : IHostedService, IDisposable
    {
        private Timer? _timer;
        private readonly SampleData _date;


        public BackGroundRefresh(SampleData sample)
        {
            _date = sample;
        }


        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(AddToCache, null, TimeSpan.Zero, TimeSpan.FromSeconds(value: 5));
            return Task.CompletedTask;

        }

        private void AddToCache(object? state)
        {
            _date.Data.Add($"The new rate has been refresh resently{DateTime.Now.ToLongTimeString()}");
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
