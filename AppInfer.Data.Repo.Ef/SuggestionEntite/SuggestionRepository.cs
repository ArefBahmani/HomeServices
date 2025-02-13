using AppDomainCore.RequestEntite.Enums;
using AppDomainCore.SuggestionEntite.Date;
using AppDomainCore.SuggestionEntite.Entite;
using AppInfer.Db.Sql.Ef.Dbase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInfer.Data.Repo.Ef.SuggestionEntite
{
    public class SuggestionRepository : ISuggestionRepository
    {
        private readonly AppDbContext _context;
        public SuggestionRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public async Task<bool> Create(Suggestion suggestion, CancellationToken cancellationToken)
        {
            var model = new Suggestion()
            {
                IsDeleted = false,
                CreatAt = DateTime.Now,
                Status = suggestion.Status,
                Description = suggestion.Description,
                Price = suggestion.Price,
                SuggestionDate = suggestion.SuggestionDate

            };
            await _context.AddAsync(model);
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<bool> Delete(int suggestionId, CancellationToken cancellationToken)
        {
          var model = await _context.Suggestions.FirstOrDefaultAsync(x => x.Id == suggestionId,cancellationToken);
            model.IsDeleted = true;
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<List<Suggestion>> GetAll(CancellationToken cancellationToken)
        {
            var models = await _context.Suggestions.AsNoTracking().ToListAsync(cancellationToken);
            return models;
        }

        public async Task<Suggestion> GetById(int id, CancellationToken cancellationToken)
        {
            var model = await _context.Suggestions.AsNoTracking().FirstOrDefaultAsync(x=>x.Id == id,cancellationToken);
            return model;
        }

        public async Task<bool> Update(int suggestionId, Suggestion suggestion, CancellationToken cancellationToken)
        {
            var model = await _context.Suggestions.FirstOrDefaultAsync(x => x.Id == suggestionId, cancellationToken);
            model = new Suggestion()
            {
                UpdateAt = DateTime.Now,
                Description = suggestion.Description,
                SuggestionDate = model.SuggestionDate,
                Price = suggestion.Price,
                Status = suggestion.Status,
            };
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
