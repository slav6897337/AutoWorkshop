﻿using AutoWorkshop.Database;
using AutoWorkshop.Models.Base;
using AutoWorkshop.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoWorkshop.Repositories.Implementations
{
    public class BaseRepository<TDbModel> : IBaseRepository<TDbModel> where TDbModel : BaseModel
    {
        private ApplicationContext Context { get; set; }

        public BaseRepository(ApplicationContext context)
        {
            Context = context;
        }
        public TDbModel Create(TDbModel model)
        {
            Context.Set<TDbModel>().Add(model);
            Context.SaveChanges();
            return model;
        }

        public void Delete(Guid id)
        {
            var toDelete = Context.Set<TDbModel>()
                .FirstOrDefault(m => m.Id == id);

            Context.Set<TDbModel>().Remove(toDelete);
            Context.SaveChanges();
        }

        public TDbModel Get(Guid id) =>
            Context.Set<TDbModel>()
            .FirstOrDefault(m => m.Id == id);

        public List<TDbModel> GetAll() => 
            Context.Set<TDbModel>().ToList();

        public TDbModel Update(TDbModel model)
        {
            var toUpdate = Context.Set<TDbModel>()
                .FirstOrDefault(m => m.Id == model.Id);
            if (toUpdate != null)
                toUpdate = model;
            Context.Update(toUpdate);
            Context.SaveChanges();
            return toUpdate;
        }
    }
}
