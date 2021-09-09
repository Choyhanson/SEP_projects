using System;
using System.Collections.Generic;
using System.Text;

namespace Antra.NBATestingApp.Data.Repository
{
    public interface IRepository<T> where T:class
    {
        int Insert(T item);
        int Update(T item);
        int Delete(int id);
        IEnumerable<T> GetAll();
        List<T> GetById(int id);
    }
}
