using Exchange;

namespace RateApi.Contracts.ApiModel
{
    public class ExchangeProvaidorApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ЕxchangeType Type { get; set; }
        public DateTime Update { get; set; }
    }
}
