using AppDomainCore.UserEntite.Dtos.CustomerDtos;
using AppDomainCore.UserEntite.Entiteies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.UserEntite.AppService.CustomerAppService
{
    public interface ICustomerAppService
    {
        public Task<bool> Add(CustomerCreateDto customer, CancellationToken cancellation);
        public Task<bool> Delete(int customerId, CancellationToken cancellation);
        public Task<bool> Edit(int CustomerId, CustomerUpdateDto customer, CancellationToken cancellation);
        public Task<Customer> GetById(int CustomerId, CancellationToken cancellation);
        public Task<List<Customer>> GetAll(CancellationToken cancellation);
    }
}
