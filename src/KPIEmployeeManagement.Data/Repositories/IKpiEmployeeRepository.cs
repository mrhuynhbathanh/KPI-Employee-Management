using KPIEmployeeManagement.Core.Models;

namespace KPIEmployeeManagement.Data.Repositories
{
    public interface IKpiEmployeeRepository
    {
        Task<List<KpiEmployee>> GetAllAsync();
        Task<KpiEmployee?> GetByIdAsync(int id);
        Task<KpiEmployee> AddAsync(KpiEmployee employee);
        Task<KpiEmployee> UpdateAsync(KpiEmployee employee);
        Task<bool> DeleteAsync(int id);
        Task SaveChangesAsync();
    }
}
