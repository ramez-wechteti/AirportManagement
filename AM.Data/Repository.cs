using AM.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        readonly AMContext context;
        public Repository(AMContext context)
        {
            this.context = context;
        }
        public void Add(T obj)
        {
            context.Add(obj);
        }
        public void Delete(T obj)
        {
            context.Remove(obj);
        }
        public T Get(int id)
        {
            return (T)context.Find(typeof(T), id);
        }
        public IList<T> GetAll()
        {
           return context.Set<T>().ToList();
        }
        public void Update(T obj)
        {
            context.Update(obj);
        }
        //public void Save()
        //{
        //    context.SaveChanges();
        //}
    }
}
