﻿using Exchange.Data.Entity;
using RateApi;

namespace RateApi.Contracts.IRepository
{
    public interface IRateRepository
    {
        void Add(Rate exchange);
        Rate Update(Rate exchange);
        void Delete(int id);
        List<Rate> GetAll();
        Rate GetById(int id);
        void ConvertAndSave(Root root);
    }

}
