using DataModel.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataModel.Models.Repositories
{
    public interface  IInfoRepository
    {
        IQueryable<Info> Items { get; }
        Info GetItemById(Guid id);
        void Update(Info item);
        void Delete(Guid id);
    }
}
