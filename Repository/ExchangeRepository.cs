using Exchange.Data;
using Exchange.Data.Entity;
using RateApi.Contracts.IRepository;

namespace Exchange.Repository
{
    public class ExchangeProvaidorRepository:IExchangeProvaidorRepository
    {
        private readonly ExchangeDBContext _context;
        public ExchangeProvaidorRepository (ExchangeDBContext context)
        {
            _context = context;
        }
        public void Add(ExchangeProvidor exchange )
        {
            _context.ExchangeProvidors.Add(exchange );
            _context.SaveChanges();
        }
        public ExchangeProvidor Update(ExchangeProvidor exchange )
        {
            var entity = _context.ExchangeProvidors.FirstOrDefault(p => p.Id == exchange.Id);

            entity.Name = exchange.Name;
            entity.Type = exchange.Type;
            entity.Update = exchange.Update;
            _context.ExchangeProvidors.Update(entity);
            _context.SaveChanges();
            return entity;
        }
        public void Delete(int id)
        {
            var querry = _context.ExchangeProvidors.Find(id);
            if (querry != null)
            {
                _context.ExchangeProvidors.Remove(querry);
            }
            _context.SaveChanges();
        }
        public List<ExchangeProvidor> GetAll()
        {
            return _context.ExchangeProvidors.ToList();
        }
        public ExchangeProvidor GetById(int id)
        {
            return _context.ExchangeProvidors.FirstOrDefault(e => e.Id == id);
        }

    }
}
