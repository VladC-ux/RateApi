namespace Exchange.Data.Entity
{
    public class Rate
    {
        public int Id { get; set; }
        public decimal Currecny { get; set; }
        public decimal Buy { get; set; }
        public decimal Sell { get; set; }
        public int ExchangeProvaidorId { get; set; }
        public ExchangeProvaidor ExchangeProvaidor { get; set; }
    }
}
