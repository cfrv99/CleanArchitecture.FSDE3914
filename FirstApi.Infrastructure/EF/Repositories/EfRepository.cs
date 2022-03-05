using FirstApi.Domain.Repositories;
using FirstApi.Infrastructure.EF.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApi.Infrastructure.EF.Repositories
{
    public class EfRepository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext context;

        public EfRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task Add(T entity)
        {
            await context.Set<T>().AddAsync(entity);
        }

        public async Task<int> Commit()
        {
            return await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var dataObject = await GetById(id);
            context.Set<T>().Remove(dataObject);
        }

        public IQueryable<T> GetAll()
        {
            return context.Set<T>();
        }

        public async Task<T> GetById(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public async Task Update(T entity)
        {
            context.Set<T>().Update(entity);
        }

    }
}
