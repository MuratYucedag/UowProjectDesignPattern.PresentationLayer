using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UowProjectDesignPattern.DataAccessLayer.Abstract;
using UowProjectDesignPattern.DataAccessLayer.Concrete;

namespace UowProjectDesignPattern.DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly Context _context;
        public GenericRepository(Context context)
        {
            _context = context;
        }

        public void Delete(T t)
        {
            _context.Remove(t);
        }

        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return _context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            _context.Add(t);
        }

        public void Update(T t)
        {
            _context.Update(t);
        }

        public void MultiUpdate(List<T> t)
        {
            _context.UpdateRange(t);
        }
    }
}
