using AppDomainCore.BaseEntity.Service;
using AppDomainCore.SubCategoryEntite.Entite;
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
        private readonly IBaseService _baseSevices;
        private readonly IAdminRepository  _adminRepository;
        public AdminAppService(IAdminRepository adminAppService, IBaseService baseService)
        {
            _adminRepository = adminAppService;
            _baseSevices = baseService;
        }
        public async Task<bool> Create(AdminCreateDto adminCreateDto, CancellationToken cancellationToken)
        {
            adminCreateDto.Image = await _baseSevices.UploadImage("Adminn", adminCreateDto.ProfileImgFile!, cancellationToken);
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
