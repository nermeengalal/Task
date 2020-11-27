using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_core_mvc.Services
{
   public interface IService<T>
    {
        List<T> GetAll();
        void Add(T Model);
        T GetDetails(int id);
        void Update(int id, T Model);
        void Delete(int id);
    }
}
