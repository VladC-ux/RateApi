using Exchange.Data.Entity;
using Exchange.Repository;
using RateApi.Contracts.ApiModel;
using RateApi.Contracts.IRepository;
using RateApi.Contracts.IService;

namespace Exchange.Service
{
    public class ExchangeProvaidorService : IExchangeProvaidorService
    {
        private readonly IExchangeProvaidorRepository _exchange;
        public ExchangeProvaidorService(IExchangeProvaidorRepository exchange)
        {
            _exchange = exchange;
        }
        public void Add(ExchangeProvidorApiModel model)
        {
            ExchangeProvidor change = new ExchangeProvidor
            {
                Name = model.Name,
                Type = model.Type,
                Update = model.Update,
            };
            _exchange.Add(change);
        }
        public void Delete(ExchangeProvidorApiModel model)
        {
            _exchange.Delete(model.Id);
        }
        public List<ExchangeProvidorApiModel> GetAll()
        {
            var data = _exchange.GetAll();
            List<ExchangeProvidorApiModel> changeapimodels = data.Select(change => new ExchangeProvidorApiModel
            {
                Id = change.Id,
                Name = change.Name,
                Type = change.Type,

            }).ToList();
            return changeapimodels;
        }
        public ExchangeProvidorApiModel GetById(int exchangeid)
        {
            var exchange = _exchange.GetById(exchangeid);
            return new ExchangeProvidorApiModel
            {
                Id = exchange.Id,
                Name = exchange.Name,
                Type = exchange.Type,
                Update = exchange.Update
            };
        }
        public ExchangeProvidor Update(ExchangeProvidorApiModel exchange)
        {
            ExchangeProvidor change = new ExchangeProvidor
            {
                Id = exchange.Id,
                Name = exchange.Name,
                Type = exchange.Type,
                Update = exchange.Update,
            };
            _exchange.Update(change);
            return change;
        }    
    }
}
