using AppDomainCore.UserEntite.Data;
using AppDomainCore.UserEntite.Dtos.ExpertDtos;
using AppDomainCore.UserEntite.Entiteies;
using AppInfer.Db.Sql.Ef.Dbase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInfer.Data.Repo.Ef.UserEntite
{
    public class ExpertRepository : IExpertRepository
    {
        private readonly AppDbContext _context;
        public ExpertRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        

        public async Task<bool> Add(ExpertCreateDto expert, CancellationToken cancellation)
        {
            var model = new Expert()
            {
                PhoneNumber = expert.PhoneNumber,
                CreatAt = DateTime.Now,
            };
            if (model == null)
            {
                return false;
            }
            await _context.AddAsync(model, cancellation);
            await _context.SaveChangesAsync(cancellation);
            
            return true;
        }

        public async Task<bool> Delete(int expertId, CancellationToken cancellation)
        {
            var model = await _context.Experts.FirstOrDefaultAsync(x=> x.Id == expertId,cancellation);
            if (model == null)
            {
                return false;
            }
            model.IsDeleted = true;
            await _context.SaveChangesAsync(cancellation);
            return true;
        }

        

        public async Task<bool> Edit(int expertId, ExpertUpdateDto expert, CancellationToken cancellation)
        {
            var model = await _context.Experts.FirstOrDefaultAsync(x => x.Id == expertId, cancellation);
            if (model == null)
            {
                return false;
            }
            model = new Expert()
            {
                ImageProfile = expert.ProfileImage,
                
                Balance = expert.Balance,
                FirstName = expert.FirstName,
                LastName = expert.LastName,
                Gender = expert.Gender,
                UpdateAt = DateTime.Now,
            };
            await _context.AddAsync(model, cancellation);
            await _context.SaveChangesAsync(cancellation);
            return true;
        }

        public async Task<List<Expert>> GetAll(CancellationToken cancellation)
        {
            var model = await _context.Experts.AsNoTracking().ToListAsync(cancellation);
            return model;
        }

        public async Task<Expert> GetById(int expertId, CancellationToken cancellation)
        {
           var model = await _context.Experts.AsNoTracking().FirstOrDefaultAsync(x=>x.Id==expertId,cancellation);
            return model;
        }
    }
}
