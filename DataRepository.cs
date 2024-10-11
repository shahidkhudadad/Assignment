using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment
{
    public class DataRepository : IDataRepository

    {
        private AssignmentDbContext _Context;
        public DataRepository(AssignmentDbContext Context)
        {
            _Context = Context;
        }

       

        public bool CreateData(Data data)
        {
            _Context.Add(data);
            return Save();
        }

        public ICollection<Data> GetAllData()
        {
            return _Context.Datas.OrderBy(c => c.FirstName).ToList();
        }

        public bool Save()
        {
            var saved = _Context.SaveChanges();
            return saved >= 0 ? true : false;
        }
    }
}
