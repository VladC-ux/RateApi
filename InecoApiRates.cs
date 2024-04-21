namespace RateApi
{
    public class Card
    {
        public double? buy { get; set; }
        public double? sell { get; set; }
    }
    public class Cash
    {
        public double? buy { get; set; }
        public double? sell { get; set; }
    }
    public class Cashless
    {
        public double? buy { get; set; }
        public double? sell { get; set; }
    }
    public class Cb
    {
        public double? buy { get; set; }
        public double? sell { get; set; }
    }
    public class Item
    {
        public string code { get; set; }
        public Cash cash { get; set; }
        public Cashless cashless { get; set; }
        public Online online { get; set; }
        public Cb cb { get; set; }
        public Card card { get; set; }
    }
    public class Online
    {
        public double? buy { get; set; }
        public double? sell { get; set; }
    }
    public class Root
    {
        public bool success { get; set; }
        public List<Item> items { get; set; }
    }
}

