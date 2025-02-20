using AppDomainCore.UserEntite.Dtos.AdminDtos;
using AppDomainCore.UserEntite.Entiteies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.UserEntite.Service.AdminService
{
    public interface IAdminService
    {
        Task<bool> Create(AdminCreateDto adminCreateDto, CancellationToken cancellationToken);
        Task<bool> Update(AdminUpdateDto adminUpdateDto, CancellationToken cancellationToken);
        Task<bool> Delete(int adminId, CancellationToken cancellationToken);
        Task<Admin> GetById(int adminId, CancellationToken cancellationToken);
        Task<List<Admin>> GetAll(CancellationToken cancellationToken);
    }
}
