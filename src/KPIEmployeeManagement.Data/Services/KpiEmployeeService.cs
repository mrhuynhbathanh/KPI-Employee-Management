using KPIEmployeeManagement.Core.Models;
using KPIEmployeeManagement.Data.Repositories;

namespace KPIEmployeeManagement.Data.Services
{
    public class KpiEmployeeService : IKpiEmployeeService
    {
        private readonly IKpiEmployeeRepository _repository;

        public KpiEmployeeService(IKpiEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<KpiEmployee>> GetAllEmployeesAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<KpiEmployee?> GetEmployeeByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<KpiEmployee> CreateEmployeeAsync(KpiEmployee employee)
        {
            if (string.IsNullOrWhiteSpace(employee.Employee))
                throw new ArgumentException("Tên nhân viên không được để trống");

            if (string.IsNullOrWhiteSpace(employee.Empno))
                throw new ArgumentException("Mã nhân viên không được để trống");

            return await _repository.AddAsync(employee);
        }

        public async Task<KpiEmployee> UpdateEmployeeAsync(KpiEmployee employee)
        {
            var existingEmployee = await _repository.GetByIdAsync(employee.Seq);
            if (existingEmployee == null)
                throw new InvalidOperationException($"Không tìm thấy nhân viên với ID: {employee.Seq}");

            return await _repository.UpdateAsync(employee);
        }

        public async Task<bool> DeleteEmployeeAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
