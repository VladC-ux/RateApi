namespace Exchange.Data.Entity
{
    public class Rate
    {
        public int Id { get; set; }
        public string Currecny { get; set; }
        public double Buy { get; set; }
        public double Sell { get; set; }
        public DateTime SyncDate { get; set; }
        public int ExchangeProvidorId { get; set; }
        public ExchangeProvidor ExchangeProvidor { get; set; }
    }
}
