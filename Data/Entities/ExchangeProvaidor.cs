namespace Exchange.Data.Entity
{
    public class ExchangeProvaidor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Type Types { get; set; }

        public DateTime Update { get; set; }

        public ICollection<Rate> Reights { get; set; }
    }
}
