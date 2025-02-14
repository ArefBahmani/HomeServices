using AppDomainCore.RequestEntite.Data;
using AppDomainCore.RequestEntite.Entite;
using AppDomainCore.RequestEntite.Enums;
using AppInfer.Db.Sql.Ef.Dbase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInfer.Data.Repo.Ef.RequestEntite
{
    public class RequestRepository : IRequestRepository
    {
        private readonly AppDbContext _context;
        public RequestRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public async Task<bool> ChangeStatus(StatusEnum status, int requestId, CancellationToken cancellationToken)
        {
            var req = await _context.Requests.FirstOrDefaultAsync(x=>x.Id == requestId,cancellationToken);
            if (req == null)
            {
                return false;
            }
            req.Status = status;
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<bool> Create(Request request, CancellationToken cancellationToken)
        {
            var req = new Request()
            {
                CategoryServiceId = request.CategoryServiceId,
                CustomerId = request.CustomerId,
                DateRequest = DateTime.Now,
                ExpertId = request.ExpertId,
                Location = request.Location,
                Description = request.Description,
                Status = StatusEnum.WaitingForExperts,
                Titel = request.Titel,
       
            };
            if (req == null)
            {
                return false;
            }
            await _context.AddAsync(req);
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<bool> Delete(int requestId, CancellationToken cancellationToken)
        {
          var model = await _context.Requests.FirstOrDefaultAsync(x=> x.Id == requestId,cancellationToken);
            if (model == null)
            {
                return false;
            }
            model.IsDeleted = true;
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<List<Request>> GetAll(CancellationToken cancellationToken)
        {
           var models = await _context.Requests.AsNoTracking().ToListAsync(cancellationToken);
            return models;
        }

        public async Task<Request> GetById(int id, CancellationToken cancellationToken)
        {
           var model = await _context.Requests.AsNoTracking().FirstOrDefaultAsync(x=> x.Id == id,cancellationToken);
            return model;
        }

     

        public async Task<bool> Update(int requestId, Request request, CancellationToken cancellationToken)
        {
            var model = await _context.Requests.FirstOrDefaultAsync(x=> x.Id == requestId,cancellationToken);
            if (model == null)
            {
                return false;
            }
            model = new Request()
            {
                CategoryServiceId = request.CategoryServiceId,
                CustomerId = request.CustomerId,
                DateRequest = DateTime.Now,
                ExpertId = request.ExpertId,
                Location = request.Location,
                Description = request.Description,
                Status = request.Status,
                Titel = request.Titel,
            };
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
