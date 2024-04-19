using System.Collections.Concurrent;

namespace RateApi.Service
{
    public class SampleData
    {
        public ConcurrentBag<string> Data { get; set; } = new();
    }
}
