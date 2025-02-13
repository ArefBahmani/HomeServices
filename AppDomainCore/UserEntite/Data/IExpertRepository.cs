using AppDomainCore.UserEntite.Entiteies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.UserEntite.Data
{
    public interface IExpertRepository
    {
        public Task<bool> Add(Expert expert, CancellationToken cancellation);
        public Task<bool> Delete(int expertId, CancellationToken cancellation);
        public Task<bool> Edit(int expertId, Expert expert, CancellationToken cancellation);
        public Task<Expert> GetById(int expertId, CancellationToken cancellation);
        public Task<List<Expert>> GetAll(CancellationToken cancellation);
    }
}
