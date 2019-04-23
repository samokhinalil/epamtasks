using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAndAwards.Storage
{
    public interface IStorage<T>
    {
        void Add(T item);
        void Remove(T item);
        T GetByID(int index);
        List<T> GetAll();
    }
}
