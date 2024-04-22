using Exchange.Data.Entity;
using Exchange.Data;
using RateApi;
using RateApi.Contracts.IRepository;

namespace Exchange.Repository
{
    public class RateRepository : IRateRepository
    {
        private readonly ExchangeDBContext _context;
        public RateRepository(ExchangeDBContext context)
        {
            _context = context;
        }
        public void Add(Rate reight)
        {
            _context.Rates.Add(reight);
            _context.SaveChanges();

        }
        public Rate Update(Rate reight)
        {

            var entity = _context.Rates.FirstOrDefault(p => p.Id == reight.Id);
            entity.Sell = reight.Sell;
            entity.Buy = reight.Buy;
            entity.Currecny = reight.Currecny;
            _context.Rates.Update(entity);
            _context.SaveChanges();
            return entity;
        }
        public void Delete(int id)
        {
            var querry = _context.ExchangeProvaidors.Find(id);
            if (querry != null)
            {
                _context.ExchangeProvaidors.Remove(querry);
            }
        }
        public List<Rate> GetAll()
        {
            return _context.Rates.ToList();
        }
        public Rate GetById(int id)
        {
            return _context.Rates.FirstOrDefault(r => r.Id == id);
        }


        public void ConvertAndSave(Root root)
        {
            DateTime currentDateTime = DateTime.Now; 

            foreach (var item in root.items)
            {
                Rate rate = new Rate
                {
                    Currecny = item.code,
                    Buy = (double)item.online.buy,
                    Sell = (double)item.online.sell,
                    SyncDate = currentDateTime 
                };

                _context.Rates.Add(rate);
            }

            _context.SaveChanges();
        }



















    }
}
