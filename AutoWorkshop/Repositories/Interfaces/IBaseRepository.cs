using AutoWorkshop.Models.Base;
using System;
using System.Collections.Generic;

namespace AutoWorkshop.Repositories.Interfaces
{
    public interface IBaseRepository<TDbModel> where TDbModel : BaseModel
    {
        List<TDbModel> GetAll();
        TDbModel Get(Guid id);
        TDbModel Create(TDbModel model);
        TDbModel Update(TDbModel model);
        void Delete(Guid id);
    }
}
