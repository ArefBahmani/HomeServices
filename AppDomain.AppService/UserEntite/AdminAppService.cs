using AppDomainCore.UserEntite.AppService.AdminAppService;
using AppDomainCore.UserEntite.Data;
using AppDomainCore.UserEntite.Dtos.AdminDtos;
using AppDomainCore.UserEntite.Entiteies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain.AppService.UserEntite
{
    public class AdminAppService : IAdminAppService
    {
        private readonly IAdminRepository  _adminRepository;
        public AdminAppService(IAdminRepository adminAppService)
        {
            _adminRepository = adminAppService;
        }
        public async Task<bool> Create(AdminCreateDto adminCreateDto, CancellationToken cancellationToken)
        {
            return await _adminRepository.Add(adminCreateDto, cancellationToken);
        }

        public async Task<bool> Delete(int adminId, CancellationToken cancellationToken)
        {
           return await _adminRepository.Delete(adminId, cancellationToken);
        }

        public async Task<List<Admin>> GetAll(CancellationToken cancellationToken)
        {
            return await _adminRepository.GetAll(cancellationToken);
        }

        public async Task<Admin> GetById(int adminId, CancellationToken cancellationToken)
        {
            return await _adminRepository.GetById(adminId, cancellationToken);
        }

        public async Task<bool> Update(AdminUpdateDto adminUpdateDto, CancellationToken cancellationToken)
        {
            return await _adminRepository.Edit(adminUpdateDto.Id,adminUpdateDto, cancellationToken);
        }
    }
}
