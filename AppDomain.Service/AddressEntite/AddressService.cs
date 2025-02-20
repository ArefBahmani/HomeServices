using AppDomainCore.AddressEntitie.Data;
using AppDomainCore.AddressEntitie.Dtos;
using AppDomainCore.AddressEntitie.Entite;
using AppDomainCore.AddressEntitie.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain.Service.AddressEntite
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;
        public AddressService(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }
        public async Task<bool> Creat(CreateAddressDto address, CancellationToken cancellationToken)
        {
            return await _addressRepository.Creat(address, cancellationToken);
        }

        public async Task<bool> Delete(int addressId, CancellationToken cancellationToken)
        {
            return await _addressRepository.Delete(addressId, cancellationToken);
        }

        public Task<Address> GetAddressById(int addressId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Address>> GetAllAddresses(CancellationToken cancellationToken)
        {
            return await _addressRepository.GetAllAddresses(cancellationToken);
        }

        public async Task<bool> Update(int addressId, UpdateAddressDto address, CancellationToken cancellationToken)
        {
            return await _addressRepository.Update(addressId, address, cancellationToken);
        }
    }
}
