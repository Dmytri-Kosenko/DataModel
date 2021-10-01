using DataModel.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataModel.Models
{
    public record DataManager(IInfoRepository infoRepository);
}
