using AppDomainCore.SubCategoryEntite.Entite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.SubCategoryEntite.Data
{
    public interface ISubCategoryRepository
    {
        public Task<bool> Creat(SubCategory subCategory,CancellationToken cancellationToken);
        public Task<bool> Delete(int id , CancellationToken cancellationToken);
        public Task<bool> Update(int id , SubCategory subCategory,CancellationToken cancellationToken);
        public Task<SubCategory> GetById(int id,CancellationToken cancellationToken);
        public Task<List<SubCategory>> GetAll(CancellationToken cancellationToken);
    }
}
