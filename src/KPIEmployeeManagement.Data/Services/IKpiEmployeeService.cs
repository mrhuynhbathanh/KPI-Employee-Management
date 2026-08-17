using KPIEmployeeManagement.Core.Models;

namespace KPIEmployeeManagement.Data.Services
{
    public interface IKpiEmployeeService
    {
        Task<List<KpiEmployee>> GetAllEmployeesAsync();
        Task<KpiEmployee?> GetEmployeeByIdAsync(int id);
        Task<KpiEmployee> CreateEmployeeAsync(KpiEmployee employee);
        Task<KpiEmployee> UpdateEmployeeAsync(KpiEmployee employee);
        Task<bool> DeleteEmployeeAsync(int id);
    }
}
