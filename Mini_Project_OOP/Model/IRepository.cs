using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project_OOP.Model
{
    public interface IRepository<T> where T : class
    {
        // includes รับ string ได้ตรงๆ เช่น "Customer", "Orders.Items" หรือ new IncludeSpec("Orders", filter)
        Task<IEnumerable<T>> GetAllAsync(params IncludeSpec[] includes);
        Task<IEnumerable<T>> FindAsync(Filter where, params IncludeSpec[] includes);
        Task<T> FirstOrDefaultAsync(Filter where, params IncludeSpec[] includes);
        Task<T> GetByIdAsync(int id, params IncludeSpec[] includes);
        Task<int> CountAsync(Filter where = null);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}