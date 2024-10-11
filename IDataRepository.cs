using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment
{
    public interface IDataRepository
    {
        ICollection<Data> GetAllData();
        bool CreateData(Data data);
        bool Save();
    }
}
