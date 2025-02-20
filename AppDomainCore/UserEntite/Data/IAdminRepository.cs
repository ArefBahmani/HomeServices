using AppDomainCore.UserEntite.Dtos.AdminDtos;
using AppDomainCore.UserEntite.Entiteies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.UserEntite.Data
{
    public interface IAdminRepository
    {
        public Task<bool> Add(AdminCreateDto admin, CancellationToken cancellation);
        public Task<bool> Delete(int adminId, CancellationToken cancellation);
        public Task<bool> Edit(int adminId, AdminUpdateDto admin, CancellationToken cancellation);
        public Task<Admin> GetById(int adminId, CancellationToken cancellation);
        public Task<List<Admin>> GetAll(CancellationToken cancellation);
    }
}
