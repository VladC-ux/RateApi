namespace Exchange.Data.Entity
{
    public class ExchangeProvaidor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ЕxchangeType Type { get; set; }
        public DateTime Update { get; set; }
        public ICollection<Rate> Rates { get; set; }
    }
}
