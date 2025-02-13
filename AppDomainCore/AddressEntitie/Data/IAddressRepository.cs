using AppDomainCore.AddressEntitie.Entite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.AddressEntitie.Data
{
    public interface IAddressRepository
    {
        public Task<bool> Creat(Address address,CancellationToken cancellationToken); 
        public Task<bool> Delete(int addressId,CancellationToken cancellationToken);
        public Task<bool> Update(int addressId,Address address,CancellationToken cancellationToken);
        public Task<Address> GetAddressById(int addressId,CancellationToken cancellationToken);
        public Task<List<Address>> GetAllAddresses(CancellationToken cancellationToken);
    }
}
